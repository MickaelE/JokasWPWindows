using Parse;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace JokasWPWindows
{
    static class Program
    {
        [STAThread]
        static void Main()
        {

            ParseClient.Initialize(new ParseClient.Configuration
            {
                ApplicationId = ConfigurationManager.AppSettings["APP_ID"],
                Server = ConfigurationManager.AppSettings["CUSTOM_SERVER_PATH"]
            });
           

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
           
        }
    }
}
