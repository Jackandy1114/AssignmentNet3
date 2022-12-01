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
        public static Dictionary<int, string> roles = new Dictionary<int, string>() {

            {1,"Admin" },{ 2, "GiangVien" },{ 3, "CanBo" }
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
                    Application.Run(new FormLogin());
                }
                if (isLogin)
                {
                    Application.Run(new FormMain());
                }
            }
        }
    }
}
