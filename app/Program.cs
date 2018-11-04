using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using app.presentation;

namespace app
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            CommandInjector.Instance.EnumeratePluginClasses("C:/Users/IosephKnecht/source/repos/calculator_solution");
            Application.Run(new MainForm());
        }
    }
}
