using System;
using System.Windows.Forms;
using CubicClock.Model;
using CubicClock.View;

namespace CubicClock
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var clock = new Clock();
            var presenter = new Presenter(clock);
            var view = new CubicClockForm();
            presenter.Attach(view);

            Application.Run(view);
        }
    }
}