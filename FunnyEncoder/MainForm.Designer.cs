namespace FunnyEncoder
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tcCodec = new System.Windows.Forms.TabControl();
            this.tpText = new System.Windows.Forms.TabPage();
            this.btnTextDescription = new System.Windows.Forms.Button();
            this.btnTextClear = new System.Windows.Forms.Button();
            this.chkOutputAsByteArray = new System.Windows.Forms.CheckBox();
            this.chkTextShowPassword = new System.Windows.Forms.CheckBox();
            this.labelTextCodec = new System.Windows.Forms.Label();
            this.cbTextCodec = new System.Windows.Forms.ComboBox();
            this.txtTextPassword = new System.Windows.Forms.TextBox();
            this.labelTextPassword = new System.Windows.Forms.Label();
            this.btnTextDecode = new System.Windows.Forms.Button();
            this.btnTextEncode = new System.Windows.Forms.Button();
            this.txtData = new System.Windows.Forms.TextBox();
            this.msText = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.tpFile = new System.Windows.Forms.TabPage();
            this.btnFileDescription = new System.Windows.Forms.Button();
            this.chkFileShowPassword = new System.Windows.Forms.CheckBox();
            this.btnOutputFileBrowser = new System.Windows.Forms.Button();
            this.btnInputFileBrowser = new System.Windows.Forms.Button();
            this.cbFileCodec = new System.Windows.Forms.ComboBox();
            this.labelFileCodec = new System.Windows.Forms.Label();
            this.txtFilePassword = new System.Windows.Forms.TextBox();
            this.labelFilePassword = new System.Windows.Forms.Label();
            this.btnFileDecode = new System.Windows.Forms.Button();
            this.btnFileEncode = new System.Windows.Forms.Button();
            this.txtOutputFile = new System.Windows.Forms.TextBox();
            this.labelOutputFile = new System.Windows.Forms.Label();
            this.labelInputFile = new System.Windows.Forms.Label();
            this.txtInputFile = new System.Windows.Forms.TextBox();
            this.tpByteConvertText = new System.Windows.Forms.TabPage();
            this.chkByteConvertTextContainSpace = new System.Windows.Forms.CheckBox();
            this.chkByteConvertTextBinaryMode = new System.Windows.Forms.CheckBox();
            this.btnByteConvertByteClear = new System.Windows.Forms.Button();
            this.btnByteConvertTextClear = new System.Windows.Forms.Button();
            this.btnByteConvertByteToText = new System.Windows.Forms.Button();
            this.btnByteConvertTextToByte = new System.Windows.Forms.Button();
            this.txtByteConvertByte = new System.Windows.Forms.TextBox();
            this.labelByteConvertByte = new System.Windows.Forms.Label();
            this.txtByteConvertText = new System.Windows.Forms.TextBox();
            this.labelByteConvertText = new System.Windows.Forms.Label();
            this.tpByteConvertFile = new System.Windows.Forms.TabPage();
            this.chkByteConvertFileContainSpace = new System.Windows.Forms.CheckBox();
            this.chkByteConvertFileBinaryMode = new System.Windows.Forms.CheckBox();
            this.btnByteConvertOutputFileBrowser = new System.Windows.Forms.Button();
            this.btnByteConvertInputFileBrowser = new System.Windows.Forms.Button();
            this.btnByteConvertBackFile = new System.Windows.Forms.Button();
            this.btnByteConvertByteFile = new System.Windows.Forms.Button();
            this.txtByteConvertOutputFile = new System.Windows.Forms.TextBox();
            this.labelByteConvertOutputFile = new System.Windows.Forms.Label();
            this.labelByteConvertInputFile = new System.Windows.Forms.Label();
            this.txtByteConvertInputFile = new System.Windows.Forms.TextBox();
            this.tpAbout = new System.Windows.Forms.TabPage();
            this.wbMedia = new System.Windows.Forms.WebBrowser();
            this.labelAbout = new System.Windows.Forms.Label();
            this.pbAbout = new System.Windows.Forms.PictureBox();
            this.tcCodec.SuspendLayout();
            this.tpText.SuspendLayout();
            this.msText.SuspendLayout();
            this.tpFile.SuspendLayout();
            this.tpByteConvertText.SuspendLayout();
            this.tpByteConvertFile.SuspendLayout();
            this.tpAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAbout)).BeginInit();
            this.SuspendLayout();
            // 
            // tcCodec
            // 
            this.tcCodec.Controls.Add(this.tpText);
            this.tcCodec.Controls.Add(this.tpFile);
            this.tcCodec.Controls.Add(this.tpByteConvertText);
            this.tcCodec.Controls.Add(this.tpByteConvertFile);
            this.tcCodec.Controls.Add(this.tpAbout);
            this.tcCodec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcCodec.Location = new System.Drawing.Point(0, 0);
            this.tcCodec.Name = "tcCodec";
            this.tcCodec.SelectedIndex = 0;
            this.tcCodec.Size = new System.Drawing.Size(800, 450);
            this.tcCodec.TabIndex = 0;
            this.tcCodec.SelectedIndexChanged += new System.EventHandler(this.tcCodec_SelectedIndexChanged);
            // 
            // tpText
            // 
            this.tpText.Controls.Add(this.btnTextDescription);
            this.tpText.Controls.Add(this.btnTextClear);
            this.tpText.Controls.Add(this.chkOutputAsByteArray);
            this.tpText.Controls.Add(this.chkTextShowPassword);
            this.tpText.Controls.Add(this.labelTextCodec);
            this.tpText.Controls.Add(this.cbTextCodec);
            this.tpText.Controls.Add(this.txtTextPassword);
            this.tpText.Controls.Add(this.labelTextPassword);
            this.tpText.Controls.Add(this.btnTextDecode);
            this.tpText.Controls.Add(this.btnTextEncode);
            this.tpText.Controls.Add(this.txtData);
            this.tpText.Controls.Add(this.msText);
            this.tpText.Location = new System.Drawing.Point(4, 22);
            this.tpText.Name = "tpText";
            this.tpText.Padding = new System.Windows.Forms.Padding(3);
            this.tpText.Size = new System.Drawing.Size(792, 424);
            this.tpText.TabIndex = 0;
            this.tpText.Text = "文字編碼";
            this.tpText.UseVisualStyleBackColor = true;
            // 
            // btnTextDescription
            // 
            this.btnTextDescription.Location = new System.Drawing.Point(755, 40);
            this.btnTextDescription.Name = "btnTextDescription";
            this.btnTextDescription.Size = new System.Drawing.Size(20, 23);
            this.btnTextDescription.TabIndex = 4;
            this.btnTextDescription.Text = "?";
            this.btnTextDescription.UseVisualStyleBackColor = true;
            this.btnTextDescription.Click += new System.EventHandler(this.btnTextDescription_Click);
            // 
            // btnTextClear
            // 
            this.btnTextClear.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTextClear.Location = new System.Drawing.Point(620, 240);
            this.btnTextClear.Name = "btnTextClear";
            this.btnTextClear.Size = new System.Drawing.Size(100, 40);
            this.btnTextClear.TabIndex = 7;
            this.btnTextClear.Text = "清除";
            this.btnTextClear.UseVisualStyleBackColor = true;
            this.btnTextClear.Click += new System.EventHandler(this.btnTextClear_Click);
            // 
            // chkOutputAsByteArray
            // 
            this.chkOutputAsByteArray.AutoSize = true;
            this.chkOutputAsByteArray.Location = new System.Drawing.Point(605, 310);
            this.chkOutputAsByteArray.Name = "chkOutputAsByteArray";
            this.chkOutputAsByteArray.Size = new System.Drawing.Size(131, 16);
            this.chkOutputAsByteArray.TabIndex = 8;
            this.chkOutputAsByteArray.Text = "以位元組輸出 (除錯)";
            this.chkOutputAsByteArray.UseVisualStyleBackColor = true;
            // 
            // chkTextShowPassword
            // 
            this.chkTextShowPassword.AutoSize = true;
            this.chkTextShowPassword.Location = new System.Drawing.Point(736, 384);
            this.chkTextShowPassword.Name = "chkTextShowPassword";
            this.chkTextShowPassword.Size = new System.Drawing.Size(48, 16);
            this.chkTextShowPassword.TabIndex = 11;
            this.chkTextShowPassword.Text = "顯示";
            this.chkTextShowPassword.UseVisualStyleBackColor = true;
            this.chkTextShowPassword.CheckedChanged += new System.EventHandler(this.chkTextShowPassword_CheckedChanged);
            // 
            // labelTextCodec
            // 
            this.labelTextCodec.AutoSize = true;
            this.labelTextCodec.Location = new System.Drawing.Point(565, 45);
            this.labelTextCodec.Name = "labelTextCodec";
            this.labelTextCodec.Size = new System.Drawing.Size(53, 12);
            this.labelTextCodec.TabIndex = 2;
            this.labelTextCodec.Text = "編解碼器";
            // 
            // cbTextCodec
            // 
            this.cbTextCodec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTextCodec.FormattingEnabled = true;
            this.cbTextCodec.Location = new System.Drawing.Point(624, 42);
            this.cbTextCodec.Name = "cbTextCodec";
            this.cbTextCodec.Size = new System.Drawing.Size(121, 20);
            this.cbTextCodec.TabIndex = 3;
            this.cbTextCodec.SelectedIndexChanged += new System.EventHandler(this.cbTextCodec_SelectedIndexChanged);
            // 
            // txtTextPassword
            // 
            this.txtTextPassword.Location = new System.Drawing.Point(605, 382);
            this.txtTextPassword.Name = "txtTextPassword";
            this.txtTextPassword.PasswordChar = '*';
            this.txtTextPassword.Size = new System.Drawing.Size(125, 22);
            this.txtTextPassword.TabIndex = 10;
            // 
            // labelTextPassword
            // 
            this.labelTextPassword.AutoSize = true;
            this.labelTextPassword.Location = new System.Drawing.Point(570, 385);
            this.labelTextPassword.Name = "labelTextPassword";
            this.labelTextPassword.Size = new System.Drawing.Size(29, 12);
            this.labelTextPassword.TabIndex = 9;
            this.labelTextPassword.Text = "密碼";
            // 
            // btnTextDecode
            // 
            this.btnTextDecode.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTextDecode.Location = new System.Drawing.Point(620, 170);
            this.btnTextDecode.Name = "btnTextDecode";
            this.btnTextDecode.Size = new System.Drawing.Size(100, 40);
            this.btnTextDecode.TabIndex = 6;
            this.btnTextDecode.Text = "解碼";
            this.btnTextDecode.UseVisualStyleBackColor = true;
            this.btnTextDecode.Click += new System.EventHandler(this.btnTextDecode_Click);
            // 
            // btnTextEncode
            // 
            this.btnTextEncode.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTextEncode.Location = new System.Drawing.Point(620, 100);
            this.btnTextEncode.Name = "btnTextEncode";
            this.btnTextEncode.Size = new System.Drawing.Size(100, 40);
            this.btnTextEncode.TabIndex = 5;
            this.btnTextEncode.Text = "編碼";
            this.btnTextEncode.UseVisualStyleBackColor = true;
            this.btnTextEncode.Click += new System.EventHandler(this.btnTextEncode_Click);
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(6, 30);
            this.txtData.Multiline = true;
            this.txtData.Name = "txtData";
            this.txtData.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtData.Size = new System.Drawing.Size(544, 388);
            this.txtData.TabIndex = 1;
            // 
            // msText
            // 
            this.msText.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiEdit});
            this.msText.Location = new System.Drawing.Point(3, 3);
            this.msText.Name = "msText";
            this.msText.Size = new System.Drawing.Size(786, 24);
            this.msText.TabIndex = 0;
            this.msText.Text = "文字編碼選單";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOpenFile,
            this.tsmiSaveAs});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(43, 20);
            this.tsmiFile.Text = "檔案";
            // 
            // tsmiOpenFile
            // 
            this.tsmiOpenFile.Name = "tsmiOpenFile";
            this.tsmiOpenFile.Size = new System.Drawing.Size(122, 22);
            this.tsmiOpenFile.Text = "開啟檔案";
            this.tsmiOpenFile.Click += new System.EventHandler(this.tsmiOpenFile_Click);
            // 
            // tsmiSaveAs
            // 
            this.tsmiSaveAs.Name = "tsmiSaveAs";
            this.tsmiSaveAs.Size = new System.Drawing.Size(122, 22);
            this.tsmiSaveAs.Text = "另存新檔";
            this.tsmiSaveAs.Click += new System.EventHandler(this.tsmiSaveAs_Click);
            // 
            // tsmiEdit
            // 
            this.tsmiEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCopy});
            this.tsmiEdit.Name = "tsmiEdit";
            this.tsmiEdit.Size = new System.Drawing.Size(43, 20);
            this.tsmiEdit.Text = "編輯";
            // 
            // tsmiCopy
            // 
            this.tsmiCopy.Name = "tsmiCopy";
            this.tsmiCopy.Size = new System.Drawing.Size(146, 22);
            this.tsmiCopy.Text = "複製文字內容";
            this.tsmiCopy.Click += new System.EventHandler(this.tsmiCopy_Click);
            // 
            // tpFile
            // 
            this.tpFile.Controls.Add(this.btnFileDescription);
            this.tpFile.Controls.Add(this.chkFileShowPassword);
            this.tpFile.Controls.Add(this.btnOutputFileBrowser);
            this.tpFile.Controls.Add(this.btnInputFileBrowser);
            this.tpFile.Controls.Add(this.cbFileCodec);
            this.tpFile.Controls.Add(this.labelFileCodec);
            this.tpFile.Controls.Add(this.txtFilePassword);
            this.tpFile.Controls.Add(this.labelFilePassword);
            this.tpFile.Controls.Add(this.btnFileDecode);
            this.tpFile.Controls.Add(this.btnFileEncode);
            this.tpFile.Controls.Add(this.txtOutputFile);
            this.tpFile.Controls.Add(this.labelOutputFile);
            this.tpFile.Controls.Add(this.labelInputFile);
            this.tpFile.Controls.Add(this.txtInputFile);
            this.tpFile.Location = new System.Drawing.Point(4, 22);
            this.tpFile.Name = "tpFile";
            this.tpFile.Padding = new System.Windows.Forms.Padding(3);
            this.tpFile.Size = new System.Drawing.Size(792, 424);
            this.tpFile.TabIndex = 1;
            this.tpFile.Text = "檔案編碼";
            this.tpFile.UseVisualStyleBackColor = true;
            // 
            // btnFileDescription
            // 
            this.btnFileDescription.Location = new System.Drawing.Point(285, 40);
            this.btnFileDescription.Name = "btnFileDescription";
            this.btnFileDescription.Size = new System.Drawing.Size(20, 23);
            this.btnFileDescription.TabIndex = 2;
            this.btnFileDescription.Text = "?";
            this.btnFileDescription.UseVisualStyleBackColor = true;
            this.btnFileDescription.Click += new System.EventHandler(this.btnFileDescription_Click);
            // 
            // chkFileShowPassword
            // 
            this.chkFileShowPassword.AutoSize = true;
            this.chkFileShowPassword.Location = new System.Drawing.Point(540, 239);
            this.chkFileShowPassword.Name = "chkFileShowPassword";
            this.chkFileShowPassword.Size = new System.Drawing.Size(48, 16);
            this.chkFileShowPassword.TabIndex = 11;
            this.chkFileShowPassword.Text = "顯示";
            this.chkFileShowPassword.UseVisualStyleBackColor = true;
            this.chkFileShowPassword.CheckedChanged += new System.EventHandler(this.chkFileShowPassword_CheckedChanged);
            // 
            // btnOutputFileBrowser
            // 
            this.btnOutputFileBrowser.Location = new System.Drawing.Point(540, 170);
            this.btnOutputFileBrowser.Name = "btnOutputFileBrowser";
            this.btnOutputFileBrowser.Size = new System.Drawing.Size(75, 23);
            this.btnOutputFileBrowser.TabIndex = 8;
            this.btnOutputFileBrowser.Text = "瀏覽";
            this.btnOutputFileBrowser.UseVisualStyleBackColor = true;
            this.btnOutputFileBrowser.Click += new System.EventHandler(this.btnOutputFileBrowser_Click);
            // 
            // btnInputFileBrowser
            // 
            this.btnInputFileBrowser.Location = new System.Drawing.Point(540, 105);
            this.btnInputFileBrowser.Name = "btnInputFileBrowser";
            this.btnInputFileBrowser.Size = new System.Drawing.Size(75, 23);
            this.btnInputFileBrowser.TabIndex = 5;
            this.btnInputFileBrowser.Text = "瀏覽";
            this.btnInputFileBrowser.UseVisualStyleBackColor = true;
            this.btnInputFileBrowser.Click += new System.EventHandler(this.btnInputFileBrowser_Click);
            // 
            // cbFileCodec
            // 
            this.cbFileCodec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFileCodec.FormattingEnabled = true;
            this.cbFileCodec.Location = new System.Drawing.Point(150, 42);
            this.cbFileCodec.Name = "cbFileCodec";
            this.cbFileCodec.Size = new System.Drawing.Size(121, 20);
            this.cbFileCodec.TabIndex = 1;
            this.cbFileCodec.SelectedIndexChanged += new System.EventHandler(this.cbFileCodec_SelectedIndexChanged);
            // 
            // labelFileCodec
            // 
            this.labelFileCodec.AutoSize = true;
            this.labelFileCodec.Location = new System.Drawing.Point(65, 45);
            this.labelFileCodec.Name = "labelFileCodec";
            this.labelFileCodec.Size = new System.Drawing.Size(53, 12);
            this.labelFileCodec.TabIndex = 0;
            this.labelFileCodec.Text = "編解碼器";
            // 
            // txtFilePassword
            // 
            this.txtFilePassword.Location = new System.Drawing.Point(150, 237);
            this.txtFilePassword.Name = "txtFilePassword";
            this.txtFilePassword.PasswordChar = '*';
            this.txtFilePassword.Size = new System.Drawing.Size(125, 22);
            this.txtFilePassword.TabIndex = 10;
            // 
            // labelFilePassword
            // 
            this.labelFilePassword.AutoSize = true;
            this.labelFilePassword.Location = new System.Drawing.Point(65, 240);
            this.labelFilePassword.Name = "labelFilePassword";
            this.labelFilePassword.Size = new System.Drawing.Size(29, 12);
            this.labelFilePassword.TabIndex = 9;
            this.labelFilePassword.Text = "密碼";
            // 
            // btnFileDecode
            // 
            this.btnFileDecode.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnFileDecode.Location = new System.Drawing.Point(455, 330);
            this.btnFileDecode.Name = "btnFileDecode";
            this.btnFileDecode.Size = new System.Drawing.Size(100, 40);
            this.btnFileDecode.TabIndex = 13;
            this.btnFileDecode.Text = "解碼";
            this.btnFileDecode.UseVisualStyleBackColor = true;
            this.btnFileDecode.Click += new System.EventHandler(this.btnFileDecode_Click);
            // 
            // btnFileEncode
            // 
            this.btnFileEncode.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnFileEncode.Location = new System.Drawing.Point(200, 330);
            this.btnFileEncode.Name = "btnFileEncode";
            this.btnFileEncode.Size = new System.Drawing.Size(100, 40);
            this.btnFileEncode.TabIndex = 12;
            this.btnFileEncode.Text = "編碼";
            this.btnFileEncode.UseVisualStyleBackColor = true;
            this.btnFileEncode.Click += new System.EventHandler(this.btnFileEncode_Click);
            // 
            // txtOutputFile
            // 
            this.txtOutputFile.BackColor = System.Drawing.Color.White;
            this.txtOutputFile.Location = new System.Drawing.Point(150, 172);
            this.txtOutputFile.Name = "txtOutputFile";
            this.txtOutputFile.ReadOnly = true;
            this.txtOutputFile.Size = new System.Drawing.Size(350, 22);
            this.txtOutputFile.TabIndex = 7;
            // 
            // labelOutputFile
            // 
            this.labelOutputFile.AutoSize = true;
            this.labelOutputFile.Location = new System.Drawing.Point(65, 175);
            this.labelOutputFile.Name = "labelOutputFile";
            this.labelOutputFile.Size = new System.Drawing.Size(53, 12);
            this.labelOutputFile.TabIndex = 6;
            this.labelOutputFile.Text = "輸出檔案";
            // 
            // labelInputFile
            // 
            this.labelInputFile.AutoSize = true;
            this.labelInputFile.Location = new System.Drawing.Point(65, 110);
            this.labelInputFile.Name = "labelInputFile";
            this.labelInputFile.Size = new System.Drawing.Size(53, 12);
            this.labelInputFile.TabIndex = 3;
            this.labelInputFile.Text = "輸入檔案";
            // 
            // txtInputFile
            // 
            this.txtInputFile.BackColor = System.Drawing.Color.White;
            this.txtInputFile.Location = new System.Drawing.Point(150, 107);
            this.txtInputFile.Name = "txtInputFile";
            this.txtInputFile.ReadOnly = true;
            this.txtInputFile.Size = new System.Drawing.Size(350, 22);
            this.txtInputFile.TabIndex = 4;
            // 
            // tpByteConvertText
            // 
            this.tpByteConvertText.Controls.Add(this.chkByteConvertTextContainSpace);
            this.tpByteConvertText.Controls.Add(this.chkByteConvertTextBinaryMode);
            this.tpByteConvertText.Controls.Add(this.btnByteConvertByteClear);
            this.tpByteConvertText.Controls.Add(this.btnByteConvertTextClear);
            this.tpByteConvertText.Controls.Add(this.btnByteConvertByteToText);
            this.tpByteConvertText.Controls.Add(this.btnByteConvertTextToByte);
            this.tpByteConvertText.Controls.Add(this.txtByteConvertByte);
            this.tpByteConvertText.Controls.Add(this.labelByteConvertByte);
            this.tpByteConvertText.Controls.Add(this.txtByteConvertText);
            this.tpByteConvertText.Controls.Add(this.labelByteConvertText);
            this.tpByteConvertText.Location = new System.Drawing.Point(4, 22);
            this.tpByteConvertText.Name = "tpByteConvertText";
            this.tpByteConvertText.Size = new System.Drawing.Size(792, 424);
            this.tpByteConvertText.TabIndex = 3;
            this.tpByteConvertText.Text = "文字 - 位元組轉換";
            this.tpByteConvertText.UseVisualStyleBackColor = true;
            // 
            // chkByteConvertTextContainSpace
            // 
            this.chkByteConvertTextContainSpace.AutoSize = true;
            this.chkByteConvertTextContainSpace.Checked = true;
            this.chkByteConvertTextContainSpace.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkByteConvertTextContainSpace.Location = new System.Drawing.Point(395, 214);
            this.chkByteConvertTextContainSpace.Name = "chkByteConvertTextContainSpace";
            this.chkByteConvertTextContainSpace.Size = new System.Drawing.Size(96, 16);
            this.chkByteConvertTextContainSpace.TabIndex = 7;
            this.chkByteConvertTextContainSpace.Text = "輸出包含空格";
            this.chkByteConvertTextContainSpace.UseVisualStyleBackColor = true;
            // 
            // chkByteConvertTextBinaryMode
            // 
            this.chkByteConvertTextBinaryMode.AutoSize = true;
            this.chkByteConvertTextBinaryMode.Location = new System.Drawing.Point(295, 214);
            this.chkByteConvertTextBinaryMode.Name = "chkByteConvertTextBinaryMode";
            this.chkByteConvertTextBinaryMode.Size = new System.Drawing.Size(84, 16);
            this.chkByteConvertTextBinaryMode.TabIndex = 6;
            this.chkByteConvertTextBinaryMode.Text = "二進位模式";
            this.chkByteConvertTextBinaryMode.UseVisualStyleBackColor = true;
            // 
            // btnByteConvertByteClear
            // 
            this.btnByteConvertByteClear.Location = new System.Drawing.Point(100, 226);
            this.btnByteConvertByteClear.Name = "btnByteConvertByteClear";
            this.btnByteConvertByteClear.Size = new System.Drawing.Size(75, 23);
            this.btnByteConvertByteClear.TabIndex = 4;
            this.btnByteConvertByteClear.Text = "清除";
            this.btnByteConvertByteClear.UseVisualStyleBackColor = true;
            this.btnByteConvertByteClear.Click += new System.EventHandler(this.btnByteConvertByteClear_Click);
            // 
            // btnByteConvertTextClear
            // 
            this.btnByteConvertTextClear.Location = new System.Drawing.Point(100, 26);
            this.btnByteConvertTextClear.Name = "btnByteConvertTextClear";
            this.btnByteConvertTextClear.Size = new System.Drawing.Size(75, 23);
            this.btnByteConvertTextClear.TabIndex = 1;
            this.btnByteConvertTextClear.Text = "清除";
            this.btnByteConvertTextClear.UseVisualStyleBackColor = true;
            this.btnByteConvertTextClear.Click += new System.EventHandler(this.btnByteConvertTextClear_Click);
            // 
            // btnByteConvertByteToText
            // 
            this.btnByteConvertByteToText.Location = new System.Drawing.Point(640, 210);
            this.btnByteConvertByteToText.Name = "btnByteConvertByteToText";
            this.btnByteConvertByteToText.Size = new System.Drawing.Size(100, 23);
            this.btnByteConvertByteToText.TabIndex = 9;
            this.btnByteConvertByteToText.Text = "位元組轉文字";
            this.btnByteConvertByteToText.UseVisualStyleBackColor = true;
            this.btnByteConvertByteToText.Click += new System.EventHandler(this.btnByteConvertByteToText_Click);
            // 
            // btnByteConvertTextToByte
            // 
            this.btnByteConvertTextToByte.Location = new System.Drawing.Point(510, 210);
            this.btnByteConvertTextToByte.Name = "btnByteConvertTextToByte";
            this.btnByteConvertTextToByte.Size = new System.Drawing.Size(100, 23);
            this.btnByteConvertTextToByte.TabIndex = 8;
            this.btnByteConvertTextToByte.Text = "文字轉位元組";
            this.btnByteConvertTextToByte.UseVisualStyleBackColor = true;
            this.btnByteConvertTextToByte.Click += new System.EventHandler(this.btnByteConvertTextToByte_Click);
            // 
            // txtByteConvertByte
            // 
            this.txtByteConvertByte.Location = new System.Drawing.Point(40, 260);
            this.txtByteConvertByte.Multiline = true;
            this.txtByteConvertByte.Name = "txtByteConvertByte";
            this.txtByteConvertByte.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtByteConvertByte.Size = new System.Drawing.Size(700, 125);
            this.txtByteConvertByte.TabIndex = 5;
            // 
            // labelByteConvertByte
            // 
            this.labelByteConvertByte.AutoSize = true;
            this.labelByteConvertByte.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelByteConvertByte.Location = new System.Drawing.Point(20, 225);
            this.labelByteConvertByte.Name = "labelByteConvertByte";
            this.labelByteConvertByte.Size = new System.Drawing.Size(57, 20);
            this.labelByteConvertByte.TabIndex = 3;
            this.labelByteConvertByte.Text = "位元組";
            // 
            // txtByteConvertText
            // 
            this.txtByteConvertText.Location = new System.Drawing.Point(40, 60);
            this.txtByteConvertText.Multiline = true;
            this.txtByteConvertText.Name = "txtByteConvertText";
            this.txtByteConvertText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtByteConvertText.Size = new System.Drawing.Size(700, 125);
            this.txtByteConvertText.TabIndex = 2;
            // 
            // labelByteConvertText
            // 
            this.labelByteConvertText.AutoSize = true;
            this.labelByteConvertText.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelByteConvertText.Location = new System.Drawing.Point(20, 25);
            this.labelByteConvertText.Name = "labelByteConvertText";
            this.labelByteConvertText.Size = new System.Drawing.Size(41, 20);
            this.labelByteConvertText.TabIndex = 0;
            this.labelByteConvertText.Text = "文字";
            // 
            // tpByteConvertFile
            // 
            this.tpByteConvertFile.Controls.Add(this.chkByteConvertFileContainSpace);
            this.tpByteConvertFile.Controls.Add(this.chkByteConvertFileBinaryMode);
            this.tpByteConvertFile.Controls.Add(this.btnByteConvertOutputFileBrowser);
            this.tpByteConvertFile.Controls.Add(this.btnByteConvertInputFileBrowser);
            this.tpByteConvertFile.Controls.Add(this.btnByteConvertBackFile);
            this.tpByteConvertFile.Controls.Add(this.btnByteConvertByteFile);
            this.tpByteConvertFile.Controls.Add(this.txtByteConvertOutputFile);
            this.tpByteConvertFile.Controls.Add(this.labelByteConvertOutputFile);
            this.tpByteConvertFile.Controls.Add(this.labelByteConvertInputFile);
            this.tpByteConvertFile.Controls.Add(this.txtByteConvertInputFile);
            this.tpByteConvertFile.Location = new System.Drawing.Point(4, 22);
            this.tpByteConvertFile.Name = "tpByteConvertFile";
            this.tpByteConvertFile.Size = new System.Drawing.Size(792, 424);
            this.tpByteConvertFile.TabIndex = 4;
            this.tpByteConvertFile.Text = "檔案 - 位元組轉換";
            this.tpByteConvertFile.UseVisualStyleBackColor = true;
            // 
            // chkByteConvertFileContainSpace
            // 
            this.chkByteConvertFileContainSpace.AutoSize = true;
            this.chkByteConvertFileContainSpace.Location = new System.Drawing.Point(400, 240);
            this.chkByteConvertFileContainSpace.Name = "chkByteConvertFileContainSpace";
            this.chkByteConvertFileContainSpace.Size = new System.Drawing.Size(96, 16);
            this.chkByteConvertFileContainSpace.TabIndex = 7;
            this.chkByteConvertFileContainSpace.Text = "輸出包含空格";
            this.chkByteConvertFileContainSpace.UseVisualStyleBackColor = true;
            // 
            // chkByteConvertFileBinaryMode
            // 
            this.chkByteConvertFileBinaryMode.AutoSize = true;
            this.chkByteConvertFileBinaryMode.Location = new System.Drawing.Point(200, 240);
            this.chkByteConvertFileBinaryMode.Name = "chkByteConvertFileBinaryMode";
            this.chkByteConvertFileBinaryMode.Size = new System.Drawing.Size(84, 16);
            this.chkByteConvertFileBinaryMode.TabIndex = 6;
            this.chkByteConvertFileBinaryMode.Text = "二進位模式";
            this.chkByteConvertFileBinaryMode.UseVisualStyleBackColor = true;
            // 
            // btnByteConvertOutputFileBrowser
            // 
            this.btnByteConvertOutputFileBrowser.Location = new System.Drawing.Point(540, 170);
            this.btnByteConvertOutputFileBrowser.Name = "btnByteConvertOutputFileBrowser";
            this.btnByteConvertOutputFileBrowser.Size = new System.Drawing.Size(75, 23);
            this.btnByteConvertOutputFileBrowser.TabIndex = 5;
            this.btnByteConvertOutputFileBrowser.Text = "瀏覽";
            this.btnByteConvertOutputFileBrowser.UseVisualStyleBackColor = true;
            this.btnByteConvertOutputFileBrowser.Click += new System.EventHandler(this.btnByteConvertOutputFileBrowser_Click);
            // 
            // btnByteConvertInputFileBrowser
            // 
            this.btnByteConvertInputFileBrowser.Location = new System.Drawing.Point(540, 105);
            this.btnByteConvertInputFileBrowser.Name = "btnByteConvertInputFileBrowser";
            this.btnByteConvertInputFileBrowser.Size = new System.Drawing.Size(75, 23);
            this.btnByteConvertInputFileBrowser.TabIndex = 2;
            this.btnByteConvertInputFileBrowser.Text = "瀏覽";
            this.btnByteConvertInputFileBrowser.UseVisualStyleBackColor = true;
            this.btnByteConvertInputFileBrowser.Click += new System.EventHandler(this.btnByteConvertInputFileBrowser_Click);
            // 
            // btnByteConvertBackFile
            // 
            this.btnByteConvertBackFile.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnByteConvertBackFile.Location = new System.Drawing.Point(400, 330);
            this.btnByteConvertBackFile.Name = "btnByteConvertBackFile";
            this.btnByteConvertBackFile.Size = new System.Drawing.Size(200, 40);
            this.btnByteConvertBackFile.TabIndex = 9;
            this.btnByteConvertBackFile.Text = "轉換為原始檔案";
            this.btnByteConvertBackFile.UseVisualStyleBackColor = true;
            this.btnByteConvertBackFile.Click += new System.EventHandler(this.btnByteConvertBackFile_Click);
            // 
            // btnByteConvertByteFile
            // 
            this.btnByteConvertByteFile.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnByteConvertByteFile.Location = new System.Drawing.Point(100, 330);
            this.btnByteConvertByteFile.Name = "btnByteConvertByteFile";
            this.btnByteConvertByteFile.Size = new System.Drawing.Size(200, 40);
            this.btnByteConvertByteFile.TabIndex = 8;
            this.btnByteConvertByteFile.Text = "轉換為位元組文字檔案";
            this.btnByteConvertByteFile.UseVisualStyleBackColor = true;
            this.btnByteConvertByteFile.Click += new System.EventHandler(this.btnByteConvertByteFile_Click);
            // 
            // txtByteConvertOutputFile
            // 
            this.txtByteConvertOutputFile.BackColor = System.Drawing.Color.White;
            this.txtByteConvertOutputFile.Location = new System.Drawing.Point(150, 172);
            this.txtByteConvertOutputFile.Name = "txtByteConvertOutputFile";
            this.txtByteConvertOutputFile.ReadOnly = true;
            this.txtByteConvertOutputFile.Size = new System.Drawing.Size(350, 22);
            this.txtByteConvertOutputFile.TabIndex = 4;
            // 
            // labelByteConvertOutputFile
            // 
            this.labelByteConvertOutputFile.AutoSize = true;
            this.labelByteConvertOutputFile.Location = new System.Drawing.Point(65, 175);
            this.labelByteConvertOutputFile.Name = "labelByteConvertOutputFile";
            this.labelByteConvertOutputFile.Size = new System.Drawing.Size(53, 12);
            this.labelByteConvertOutputFile.TabIndex = 3;
            this.labelByteConvertOutputFile.Text = "輸出檔案";
            // 
            // labelByteConvertInputFile
            // 
            this.labelByteConvertInputFile.AutoSize = true;
            this.labelByteConvertInputFile.Location = new System.Drawing.Point(65, 110);
            this.labelByteConvertInputFile.Name = "labelByteConvertInputFile";
            this.labelByteConvertInputFile.Size = new System.Drawing.Size(53, 12);
            this.labelByteConvertInputFile.TabIndex = 0;
            this.labelByteConvertInputFile.Text = "輸入檔案";
            // 
            // txtByteConvertInputFile
            // 
            this.txtByteConvertInputFile.BackColor = System.Drawing.Color.White;
            this.txtByteConvertInputFile.Location = new System.Drawing.Point(150, 107);
            this.txtByteConvertInputFile.Name = "txtByteConvertInputFile";
            this.txtByteConvertInputFile.ReadOnly = true;
            this.txtByteConvertInputFile.Size = new System.Drawing.Size(350, 22);
            this.txtByteConvertInputFile.TabIndex = 1;
            // 
            // tpAbout
            // 
            this.tpAbout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tpAbout.BackgroundImage")));
            this.tpAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tpAbout.Controls.Add(this.wbMedia);
            this.tpAbout.Controls.Add(this.labelAbout);
            this.tpAbout.Controls.Add(this.pbAbout);
            this.tpAbout.Location = new System.Drawing.Point(4, 22);
            this.tpAbout.Name = "tpAbout";
            this.tpAbout.Size = new System.Drawing.Size(792, 424);
            this.tpAbout.TabIndex = 2;
            this.tpAbout.Text = "關於";
            this.tpAbout.UseVisualStyleBackColor = true;
            this.tpAbout.Click += new System.EventHandler(this.tpAbout_Click);
            // 
            // wbMedia
            // 
            this.wbMedia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbMedia.IsWebBrowserContextMenuEnabled = false;
            this.wbMedia.Location = new System.Drawing.Point(0, 0);
            this.wbMedia.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbMedia.Name = "wbMedia";
            this.wbMedia.ScrollBarsEnabled = false;
            this.wbMedia.Size = new System.Drawing.Size(792, 424);
            this.wbMedia.TabIndex = 1;
            this.wbMedia.Visible = false;
            this.wbMedia.WebBrowserShortcutsEnabled = false;
            // 
            // labelAbout
            // 
            this.labelAbout.AutoSize = true;
            this.labelAbout.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelAbout.ForeColor = System.Drawing.Color.Purple;
            this.labelAbout.Location = new System.Drawing.Point(140, 40);
            this.labelAbout.Name = "labelAbout";
            this.labelAbout.Size = new System.Drawing.Size(121, 40);
            this.labelAbout.TabIndex = 0;
            this.labelAbout.Text = "Funny Encoder\r\n棉被正在看著你";
            // 
            // pbAbout
            // 
            this.pbAbout.Image = global::FunnyEncoder.Properties.Resources.OriginIcon;
            this.pbAbout.Location = new System.Drawing.Point(20, 20);
            this.pbAbout.Name = "pbAbout";
            this.pbAbout.Size = new System.Drawing.Size(100, 100);
            this.pbAbout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAbout.TabIndex = 0;
            this.pbAbout.TabStop = false;
            this.pbAbout.Click += new System.EventHandler(this.pbAbout_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tcCodec);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MainMenuStrip = this.msText;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Funny Encoder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.tcCodec.ResumeLayout(false);
            this.tpText.ResumeLayout(false);
            this.tpText.PerformLayout();
            this.msText.ResumeLayout(false);
            this.msText.PerformLayout();
            this.tpFile.ResumeLayout(false);
            this.tpFile.PerformLayout();
            this.tpByteConvertText.ResumeLayout(false);
            this.tpByteConvertText.PerformLayout();
            this.tpByteConvertFile.ResumeLayout(false);
            this.tpByteConvertFile.PerformLayout();
            this.tpAbout.ResumeLayout(false);
            this.tpAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAbout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcCodec;
        private System.Windows.Forms.TabPage tpText;
        private System.Windows.Forms.TabPage tpFile;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Label labelTextCodec;
        private System.Windows.Forms.ComboBox cbTextCodec;
        private System.Windows.Forms.TextBox txtTextPassword;
        private System.Windows.Forms.Label labelTextPassword;
        private System.Windows.Forms.Button btnTextDecode;
        private System.Windows.Forms.Button btnTextEncode;
        private System.Windows.Forms.ComboBox cbFileCodec;
        private System.Windows.Forms.Label labelFileCodec;
        private System.Windows.Forms.TextBox txtFilePassword;
        private System.Windows.Forms.Label labelFilePassword;
        private System.Windows.Forms.Button btnFileDecode;
        private System.Windows.Forms.Button btnFileEncode;
        private System.Windows.Forms.TextBox txtOutputFile;
        private System.Windows.Forms.Label labelOutputFile;
        private System.Windows.Forms.Label labelInputFile;
        private System.Windows.Forms.TextBox txtInputFile;
        private System.Windows.Forms.TabPage tpAbout;
        private System.Windows.Forms.Button btnOutputFileBrowser;
        private System.Windows.Forms.Button btnInputFileBrowser;
        private System.Windows.Forms.CheckBox chkTextShowPassword;
        private System.Windows.Forms.CheckBox chkFileShowPassword;
        private System.Windows.Forms.PictureBox pbAbout;
        private System.Windows.Forms.Label labelAbout;
        private System.Windows.Forms.CheckBox chkOutputAsByteArray;
        private System.Windows.Forms.TabPage tpByteConvertText;
        private System.Windows.Forms.Button btnByteConvertByteToText;
        private System.Windows.Forms.Button btnByteConvertTextToByte;
        private System.Windows.Forms.TextBox txtByteConvertByte;
        private System.Windows.Forms.Label labelByteConvertByte;
        private System.Windows.Forms.TextBox txtByteConvertText;
        private System.Windows.Forms.Label labelByteConvertText;
        private System.Windows.Forms.WebBrowser wbMedia;
        private System.Windows.Forms.Button btnTextClear;
        private System.Windows.Forms.Button btnByteConvertByteClear;
        private System.Windows.Forms.Button btnByteConvertTextClear;
        private System.Windows.Forms.MenuStrip msText;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpenFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveAs;
        private System.Windows.Forms.ToolStripMenuItem tsmiEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopy;
        private System.Windows.Forms.Button btnTextDescription;
        private System.Windows.Forms.Button btnFileDescription;
        private System.Windows.Forms.CheckBox chkByteConvertTextBinaryMode;
        private System.Windows.Forms.TabPage tpByteConvertFile;
        private System.Windows.Forms.CheckBox chkByteConvertTextContainSpace;
        private System.Windows.Forms.Button btnByteConvertOutputFileBrowser;
        private System.Windows.Forms.Button btnByteConvertInputFileBrowser;
        private System.Windows.Forms.Button btnByteConvertBackFile;
        private System.Windows.Forms.Button btnByteConvertByteFile;
        private System.Windows.Forms.TextBox txtByteConvertOutputFile;
        private System.Windows.Forms.Label labelByteConvertOutputFile;
        private System.Windows.Forms.Label labelByteConvertInputFile;
        private System.Windows.Forms.TextBox txtByteConvertInputFile;
        private System.Windows.Forms.CheckBox chkByteConvertFileContainSpace;
        private System.Windows.Forms.CheckBox chkByteConvertFileBinaryMode;
    }
}

