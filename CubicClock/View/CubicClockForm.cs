using System.Windows.Forms;

namespace CubicClock.View
{
    public partial class CubicClockForm : Form, IView
    {
        private Presenter _presenter;

        public CubicClockForm()
        {
            InitializeComponent();
        }

        public Presenter Presenter
        {
            set { _presenter = value; }
        }

        public int Hour
        {
            set { _hourCubic.Value = value; ; }
        }

        public int Minute
        {
            set { _minuteCubic.Value = value; }
        }
    }
}