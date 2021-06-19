using MuhasebeApp.UserUI.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuhasebeApp.UserUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
            Application.Run(new HomePage());
=======
            Application.Run(new Giris());
>>>>>>> b5b3548c601f740561f941a89a0dd7a8ccf8589c
        }
    }
}
