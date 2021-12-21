using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ude;

namespace FunnyEncoder
{
    public partial class MainForm : Form
    {
        private Codec codecText, codecFile;

        public MainForm()
        {
            InitializeComponent();

            loadCodec();
            cbTextCodec.SelectedIndex = cbFileCodec.SelectedIndex = 0;
        }

        private static void changeCodec(ref Codec codec, int index)
        {
            codec = Program.codecType[index];
        }

        private void loadCodec()
        {
            foreach (Codec codec in Program.codecType)
            {
                cbTextCodec.Items.Add(codec.name);
                cbFileCodec.Items.Add(codec.name);
            }
        }

        private static void showPassword(TextBox target, bool show)
        {
            target.PasswordChar = show ? (char)0 : '*';
        }

        private async Task outputText(byte[] data)
        {
            bool outputAsByteArray = chkOutputAsByteArray.Checked;
            string result = await Task.Run(() =>
            {
                return truncateOutputLength(outputAsByteArray ? Util.getHexString(data) : Encoding.UTF8.GetString(data));
            });
            txtData.Text = result;
            // Yep, No Return
        }

        public static byte[] encode(Codec codec, byte[] data, string key)
        {
            if (string.IsNullOrEmpty(key))
            {
                return codec.encode(data);
            }
            return codec.encrypt(data, Encoding.UTF8.GetBytes(key));
        }

        public static byte[] decode(Codec codec, byte[] data, string key)
        {
            if (string.IsNullOrEmpty(key))
            {
                return codec.decode(data);
            }
            return codec.decrypt(data, Encoding.UTF8.GetBytes(key));
        }

        private void visibleMedia(bool visible)
        {
            wbMedia.Url = visible ? new Uri(Program.MEDIA_URL) : null;
            wbMedia.Visible = visible;
        }

        private static string truncateOutputLength(string output)
        {
            if (output.Length > Program.MAX_TEXT_BOX_OUTPUT_LENGTH)
            {
                output = output.Substring(0, Program.MAX_TEXT_BOX_OUTPUT_LENGTH);
                MessageBox.Show("輸出資料過長，部分資料已截斷 (長度超過 " + Program.MAX_TEXT_BOX_OUTPUT_LENGTH + " 字元)", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return output;
        }

        private void enableTextUI(bool enable)
        {
            msText.Enabled = txtData.Enabled = cbTextCodec.Enabled
                = btnTextDescription.Enabled = btnTextEncode.Enabled = btnTextDecode.Enabled
                = btnTextClear.Enabled = chkOutputAsByteArray.Enabled = txtTextPassword.Enabled
                = chkTextShowPassword.Enabled = enable;
        }

        private async void btnTextEncode_Click(object sender, EventArgs e)
        {
            enableTextUI(false);
            string data = txtData.Text;
            string password = txtTextPassword.Text;
            try
            {
                byte[] output = await Task.Run(() => encode(codecText, Encoding.UTF8.GetBytes(data), password));
                await outputText(output);
            }
            catch (Exception ex)
            {
                MessageBox.Show("編碼資料時發生例外狀況 : " + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            enableTextUI(true);
        }

        private async void btnTextDecode_Click(object sender, EventArgs e)
        {
            enableTextUI(false);
            string data = txtData.Text;
            string password = txtTextPassword.Text;
            try
            {
                byte[] output = await Task.Run(() => decode(codecText, Encoding.UTF8.GetBytes(data), password));
                await outputText(output);
            }
            catch (Exception ex)
            {
                MessageBox.Show("解碼資料時發生例外狀況 : " + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            enableTextUI(true);
        }

        private void enableFileUI(bool enable)
        {
            cbFileCodec.Enabled = btnFileDescription.Enabled = btnInputFileBrowser.Enabled
                = btnOutputFileBrowser.Enabled = txtFilePassword.Enabled = chkFileShowPassword.Enabled
                = btnFileEncode.Enabled = btnFileDecode.Enabled = enable;
        }

        private async void btnFileEncode_Click(object sender, EventArgs e)
        {
            string input = txtInputFile.Text;
            string output = txtOutputFile.Text;
            if (string.IsNullOrWhiteSpace(input) || string.IsNullOrWhiteSpace(output))
            {
                MessageBox.Show("請指定輸入與輸出檔案", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            enableFileUI(false);
            string password = txtFilePassword.Text;
            try
            {
                await Task.Run(() => File.WriteAllBytes(output, encode(codecFile, File.ReadAllBytes(input), password)));
                MessageBox.Show("檔案編碼完成", "資訊", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("編碼檔案時發生例外狀況 : " + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            enableFileUI(true);
        }

        private async void btnFileDecode_Click(object sender, EventArgs e)
        {
            string input = txtInputFile.Text;
            string output = txtOutputFile.Text;
            if (string.IsNullOrWhiteSpace(input) || string.IsNullOrWhiteSpace(output))
            {
                MessageBox.Show("請指定輸入與輸出檔案", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            enableFileUI(false);
            string password = txtFilePassword.Text;
            try
            {
                await Task.Run(() => File.WriteAllBytes(output, decode(codecFile, File.ReadAllBytes(input), password)));
                MessageBox.Show("檔案解碼完成", "資訊", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("解碼檔案時發生例外狀況 : " + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            enableFileUI(true);
        }

        private static void openFileBrowser(TextBox target)
        {
            using (OpenFileDialog open = new OpenFileDialog()
            {
                Title = "請選擇輸入檔案"
            })
            {
                if (open.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                target.Text = open.FileName;
            }
        }

        private static void saveFileBrowser(TextBox target)
        {
            using (SaveFileDialog save = new SaveFileDialog()
            {
                Filter = "所有檔案 (*.*)|*.*",
                Title = "請指定輸出檔案"
            })
            {
                if (save.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                target.Text = save.FileName;
            }
        }

        private void btnInputFileBrowser_Click(object sender, EventArgs e)
        {
            openFileBrowser(txtInputFile);
        }

        private void btnOutputFileBrowser_Click(object sender, EventArgs e)
        {
            saveFileBrowser(txtOutputFile);
        }

        private void chkTextShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            showPassword(txtTextPassword, chkTextShowPassword.Checked);
        }

        private void chkFileShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            showPassword(txtFilePassword, chkFileShowPassword.Checked);
        }

        private void cbTextCodec_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeCodec(ref codecText, cbTextCodec.SelectedIndex);
        }

        private void cbFileCodec_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeCodec(ref codecFile, cbFileCodec.SelectedIndex);
        }

        private void pbAbout_Click(object sender, EventArgs e)
        {
            Process.Start(Program.INTRODUCTION_URL);
        }

        private void tpAbout_Click(object sender, EventArgs e)
        {
            visibleMedia(true);
        }

        private void enableByteConvertTextUI(bool enable)
        {
            btnByteConvertTextClear.Enabled = txtByteConvertText.Enabled = btnByteConvertByteClear.Enabled
                = txtByteConvertByte.Enabled = chkByteConvertTextBinaryMode.Enabled = chkByteConvertTextContainSpace.Enabled
                = btnByteConvertTextToByte.Enabled = btnByteConvertByteToText.Enabled = enable;
        }

        private async void btnByteConvertTextToByte_Click(object sender, EventArgs e)
        {
            enableByteConvertTextUI(false);
            string input = txtByteConvertText.Text;
            bool binary = chkByteConvertTextBinaryMode.Checked;
            bool space = chkByteConvertTextContainSpace.Checked;
            try
            {
                string output = await Task.Run(() =>
                {
                    byte[] data = Encoding.UTF8.GetBytes(input);
                    string ret;

                    if (binary)
                    {
                        string bitString = Util.getBitString(data);
                        ret = space ? string.Join(" ", bitString.splitLengthPart(8)) : bitString;
                    }
                    else
                    {
                        ret = Util.getHexString(data, space ? " " : string.Empty);
                    }
                    return truncateOutputLength(ret);
                });
                txtByteConvertByte.Text = output;
            }
            catch (Exception ex)
            {
                MessageBox.Show("轉換位元組時發生例外狀況 : " + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            enableByteConvertTextUI(true);
        }

        private async void btnByteConvertByteToText_Click(object sender, EventArgs e)
        {
            enableByteConvertTextUI(false);
            string input = txtByteConvertByte.Text;
            bool binary = chkByteConvertTextBinaryMode.Checked;
            try
            {
                string output = await Task.Run(() => truncateOutputLength(Encoding.UTF8.GetString(binary ? Util.bitStringToByteArray(input) : Util.hexStringToByteArray(input))));
                txtByteConvertText.Text = output;
            }
            catch (Exception ex)
            {
                MessageBox.Show("轉換字串時發生例外狀況 : " + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            enableByteConvertTextUI(true);
        }

        private void btnTextClear_Click(object sender, EventArgs e)
        {
            txtData.Text = string.Empty;
        }

        private void btnByteConvertTextClear_Click(object sender, EventArgs e)
        {
            txtByteConvertText.Text = string.Empty;
        }

        private void btnByteConvertByteClear_Click(object sender, EventArgs e)
        {
            txtByteConvertByte.Text = string.Empty;
        }

        private async void tsmiOpenFile_Click(object sender, EventArgs e)
        {
            string file = null;
            using (OpenFileDialog open = new OpenFileDialog()
            {
                Title = "請選擇開啟檔案"
            })
            {
                if (open.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                file = open.FileName;
            }

            enableTextUI(false);
            try
            {
                string text = await Task.Run(() =>
                {
                    using (FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read))
                    {
                        CharsetDetector detect = new CharsetDetector();
                        detect.Feed(fs);
                        detect.DataEnd();

                        string result = detect.Charset;
                        Encoding charset = result != null ? Encoding.GetEncoding(result) : Encoding.Default;
                        return truncateOutputLength(File.ReadAllText(file, charset));
                    }
                });
                txtData.Text = text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("開啟檔案時發生例外狀況 : " + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            enableTextUI(true);
        }

        private async void tsmiSaveAs_Click(object sender, EventArgs e)
        {
            string saveFile = null;
            using (SaveFileDialog save = new SaveFileDialog()
            {
                Filter = "所有檔案 (*.*)|*.*",
                Title = "請指定儲存檔案"
            })
            {
                if (save.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                saveFile = save.FileName;
            }

            enableTextUI(false);
            string output = txtData.Text;
            try
            {
                await Task.Run(() => File.WriteAllText(saveFile, output));
                MessageBox.Show("檔案儲存完成", "資訊", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("儲存檔案時發生例外狀況 : " + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            enableTextUI(true);
        }

        private void tsmiCopy_Click(object sender, EventArgs e)
        {
            string data = txtData.Text;
            if (data == string.Empty)
            {
                Clipboard.Clear();
            }
            else
            {
                Clipboard.SetText(data);
            }
        }

        private static void showHelp(Codec codec)
        {
            MessageBox.Show(codec.description, "說明", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTextDescription_Click(object sender, EventArgs e)
        {
            showHelp(codecText);
        }

        private void btnFileDescription_Click(object sender, EventArgs e)
        {
            showHelp(codecFile);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }

        private void btnByteConvertInputFileBrowser_Click(object sender, EventArgs e)
        {
            openFileBrowser(txtByteConvertInputFile);
        }

        private void btnByteConvertOutputFileBrowser_Click(object sender, EventArgs e)
        {
            saveFileBrowser(txtByteConvertOutputFile);
        }

        private void enableByteConvertFileUI(bool enable)
        {
            btnByteConvertInputFileBrowser.Enabled = btnByteConvertOutputFileBrowser.Enabled = chkByteConvertFileBinaryMode.Enabled
                = chkByteConvertFileContainSpace.Enabled = btnByteConvertByteFile.Enabled = btnByteConvertBackFile.Enabled
                = enable;
        }

        private async void btnByteConvertByteFile_Click(object sender, EventArgs e)
        {
            string input = txtByteConvertInputFile.Text;
            string output = txtByteConvertOutputFile.Text;
            if (string.IsNullOrWhiteSpace(input) || string.IsNullOrWhiteSpace(output))
            {
                MessageBox.Show("請指定輸入與輸出檔案", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            enableByteConvertFileUI(false);
            bool binary = chkByteConvertFileBinaryMode.Checked;
            bool space = chkByteConvertFileContainSpace.Checked;
            try
            {
                await Task.Run(() =>
                {
                    byte[] data = File.ReadAllBytes(input);
                    string ret;

                    if (binary)
                    {
                        string bitString = Util.getBitString(data);
                        ret = space ? string.Join(" ", bitString.splitLengthPart(8)) : bitString;
                    }
                    else
                    {
                        ret = Util.getHexString(data, space ? " " : string.Empty);
                    }
                    File.WriteAllText(output, ret);
                });
                MessageBox.Show("檔案位元組轉換完成", "資訊", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("轉換檔案位元組時發生例外狀況 : " + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            enableByteConvertFileUI(true);
        }

        private async void btnByteConvertBackFile_Click(object sender, EventArgs e)
        {
            string input = txtByteConvertInputFile.Text;
            string output = txtByteConvertOutputFile.Text;
            if (string.IsNullOrWhiteSpace(input) || string.IsNullOrWhiteSpace(output))
            {
                MessageBox.Show("請指定輸入與輸出檔案", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            enableByteConvertFileUI(false);
            bool binary = chkByteConvertFileBinaryMode.Checked;
            try
            {
                await Task.Run(() =>
                {
                    string data = File.ReadAllText(input);
                    File.WriteAllBytes(output, binary ? Util.bitStringToByteArray(data) : Util.hexStringToByteArray(data));
                });
                MessageBox.Show("原始檔案轉換完成", "資訊", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("轉換原始檔案時發生例外狀況 : " + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            enableByteConvertFileUI(true);
        }

        private void tcCodec_SelectedIndexChanged(object sender, EventArgs e)
        {
            visibleMedia(false);
        }
    }
}