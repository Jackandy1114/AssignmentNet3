using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Assignment
{
    internal static class Program
    {
        public static bool isLogin { get; set; } = false;
        public static bool isLoading { get; set; } = true;
        public static string role { get; set; }
        public static ASMWINFORMEntities db = new ASMWINFORMEntities();

        public static Dictionary<string, string> roles = new Dictionary<string, string>() {

            {"Admin","Admin" },{ "GiangVien","Giảng viên" },{ "CanBo" , "Cán bộ" }
    };

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            while (isLoading)
            {
                while (!isLogin && isLoading)
                {
                    Application.Run(new _Form.FormLogin());
                }
                if (isLogin)
                {
                    Application.Run(new _Form.FormMain());
                }
            }
        }
    }
}
