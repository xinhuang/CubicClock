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
            set { _presenter = value; Refresh(); }
        }

        public int Hour
        {
            set { _hourCubic.Value = value; ; }
        }

        public int Minute
        {
            set { _minuteCubic.Value = value; }
        }

        public int Second
        {
            set { _secondCubic.Value = value; }
        }

        public override void Refresh()
        {
            _presenter.OnRefresh();
            base.Refresh();
        }
    }
}