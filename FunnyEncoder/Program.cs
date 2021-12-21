using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FunnyEncoder
{
    /*
     * 原本只是支援別人的作業，然後加入了一堆 ㄎㄧㄤ 東東
     * Quilt : 棉被
     * SmallQuilt : 小棉被
     */

    public static class Program
    {
        public const int MAX_TEXT_BOX_OUTPUT_LENGTH = 32767;

        public const string INTRODUCTION_URL = "https://intro.quilt.idv.tw/"; // Change This
        public const string MEDIA_URL = "https://smallquilt.quilt.idv.tw:8923/resource4.php"; // Change This

        public static IList<Codec> codecType
        {
            get;
            private set;
        }

        private static void initCodec()
        {
            codecType = new List<Codec>();
            foreach (Type implement in AppDomain.CurrentDomain.GetAssemblies().SelectMany(assembly => assembly.GetTypes()).Where(type => typeof(Codec).IsAssignableFrom(type) && !type.IsAbstract))
            {
                try
                {
                    codecType.Add((Codec)Activator.CreateInstance(implement));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("編解碼器初始化時發生例外狀況 : " + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            initCodec();
            Application.Run(new MainForm());
        }
    }
}