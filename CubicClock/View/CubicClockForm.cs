using System;
using System.Drawing;
using System.Windows.Forms;

namespace CubicClock.View
{
    public partial class CubicClockForm : Form, IView
    {
        private bool _moving;
        private Point _oldLocation;
        private IViewEvents _presenter;

        public CubicClockForm()
        {
            InitializeComponent();

            _hourCubic.Max = 24;
            _minuteCubic.Max = 60;
            _secondCubic.Max = 60;
        }

        #region IView Members

        public Presenter Presenter
        {
            set
            {
                _presenter = value;
                Refresh();
            }
        }

        public int Hour
        {
            set
            {
                _hourCubic.Value = value;
                ;
            }
        }

        public int Minute
        {
            set { _minuteCubic.Value = value; }
        }

        public int Second
        {
            set { _secondCubic.Value = value; }
        }

        #endregion

        public override void Refresh()
        {
            _presenter.OnRefresh();
            base.Refresh();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            _oldLocation = e.Location;
            _moving = true;

            _shortcutMenu.Visible = false;
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            _moving = false;

            if (e.Button == MouseButtons.Right)
            {
                _shortcutMenu.Visible = true;
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            if (!_moving)
                return;

            Left += e.Location.X - _oldLocation.X;
            Top += e.Location.Y - _oldLocation.Y;
        }

        private void OnExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            _shortcutMenu.Hide();
            _presenter.OnExit();
        }
    }
}