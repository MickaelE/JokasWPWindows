using Parse;
using System;
using System.Windows.Forms;

namespace JokasWPWindows
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        private static String APP_ID = "244600d975e2836676e64cb3a18ceca692a9a23c";
        private static String APP_REST_API_ID = "a9122d5ab8f97176c51a2e5cf5273dd6543bfe93";
        private static String CUSTOM_SERVER_PATH = "http://mickenet.ddns.net:81/parse/";// trailing slash is important

        [STAThread]
        static void Main()
        {

            ParseClient.Initialize(new ParseClient.Configuration
            {
                ApplicationId = APP_ID,
                Server = CUSTOM_SERVER_PATH 
            });
           

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
           
        }
    }
}
