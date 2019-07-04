using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace hamedsmms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
       // public static string salesman;

        public static string SalesMan;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PL.Form_main());
        }
    }
}
