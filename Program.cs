using System;
using System.Windows.Forms;

namespace CRLchain
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //запускающаяся при открытии приложения форма .Run
            Application.Run(new Registration());
        }
    }
}
