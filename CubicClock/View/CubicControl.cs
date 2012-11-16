using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CubicClock.View
{
    public partial class CubicControl : UserControl
    {
        private int _value;

        public CubicControl()
        {
            InitializeComponent();
        }

        [DefaultValue(60)]
        public int Max { get; set; }

        [DefaultValue(33)]
        public int Value
        {
            get { return _value; }
            set
            {
                if (_value == value)
                    return;
                _value = value;
                if (InvokeRequired)
                    Invoke(new Action(Invalidate));
                else
                    Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            int max = Max == 0 ? 1 : Max;
            var blackRegion = new RectangleF(0, 0, (float)Value / max * Width, Height);
            blackRegion.Width = Math.Min(Width, blackRegion.Width);
            using (var blackBrush = new SolidBrush(Color.Black))
            {
                e.Graphics.FillRectangle(blackBrush, blackRegion);
            }
        }
    }
}