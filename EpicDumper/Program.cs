using Auth.GG_Winform_Example;
using System;
using System.Windows.Forms;

namespace Epic_Dumper
{

    /// <summary>
    /// Class with program entry point.
    /// </summary>
    internal sealed class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Update this with your program information
            OnProgramStart.Initialize("APPNAME", "AIDHERE", "APPSECRET", "1.0");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());

        }

    }
}
