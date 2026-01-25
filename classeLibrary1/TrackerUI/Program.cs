using System;
using System.Windows.Forms;
using Library1;
namespace TrackerUI
{
    internal static class Program
    {

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration
            // inicialize the database connections

            //Library1.GlobalConfig.InitializeConnections(true, true);
            GlobalConfig.InitializeConnections(database: true, textFiles: true);
            //Application.Run(new CreatePrizeForm());
            ApplicationConfiguration.Initialize();
            Application.Run(new CreatePrizeForm());
        }
    }
}