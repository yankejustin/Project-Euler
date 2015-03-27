using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Generator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Going to move this eventually.
            // Also going to place into a try-catch block! :)
            if (!Directory.Exists(ProjectEulerFactory.DirectoryFolder))
            {
                Directory.CreateDirectory(ProjectEulerFactory.DirectoryFolder);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmGenerator());
        }
    }
}
