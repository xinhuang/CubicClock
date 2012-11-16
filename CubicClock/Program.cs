using System;
using System.Windows.Forms;
using CubicClock.View;

namespace CubicClock
{
    internal static class Program
    {
        /// <summary>
        ///   The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CubicClockForm());
        }
    }
}