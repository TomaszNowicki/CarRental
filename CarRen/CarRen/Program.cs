using System;
using System.Windows.Forms;

namespace CarRen
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.EnableVisualStyles();
            Application.Run(new Spinner());
        }
    }
}
