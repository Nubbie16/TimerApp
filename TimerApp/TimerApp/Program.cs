// Project Name: TimerApp
// Purpose: Basic timer/stopwatch program that showcases knowledge of real-time time tracking
// File Name: Program.cs
// Description: Contains the Main method, which serves as the entry point for the application and
//              initializes the stopwatchForm as the main user interface
// Programmer: Cody Eckard
// Creation Date: May 18, 2026
// GitHub Repository: https://github.com/Nubbie16/TimerApp

namespace TimerApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new mainForm());
        }
    }
}