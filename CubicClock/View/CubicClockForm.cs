using System.Windows.Forms;

namespace CubicClock.View
{
    public partial class CubicClockForm : Form, IView
    {
        public CubicClockForm()
        {
            InitializeComponent();
        }

        public Presenter Presenter
        {
            set { throw new System.NotImplementedException(); }
        }

        public int Hour
        {
            get { throw new System.NotImplementedException(); }
            set { throw new System.NotImplementedException(); }
        }

        public int Minute
        {
            get { throw new System.NotImplementedException(); }
            set { throw new System.NotImplementedException(); }
        }
    }
}