﻿using System;
using System.Windows.Forms;
using TrackerLibrary;

namespace TrackerUI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Initialize the connections
            TrackerLibrary.GlobalConfig.InitializeConnection(DatabaseType.TextFile);

            Application.Run(new CreateTeamForm());
            //Application.Run(new TournamentDashboardForm()); <- This is the startup we want later. 
        }
    }
}
/*
 
We have changed the Application.Run method, to start with the TournamentDashboardForm, instead of the CreateTournamentForm. Note that here we can define what form we want to start with, and we can also change it later on, if we want to.

The Application.Run pauses the execution of the program, until the form is closed. So, when the form is closed, the execution will continue, and the program will end.

*/
