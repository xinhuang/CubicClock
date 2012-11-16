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

        private int _max;

        public int Max
        {
            get { return _max; }
            set
            {
                _max = value; 
                InvokeInvalidate();
            }
        }

        public int Value
        {
            get { return _value; }
            set
            {
                if (_value == value)
                    return;
                _value = value;
                InvokeInvalidate();
            }
        }

        private void InvokeInvalidate()
        {
            if (InvokeRequired)
                Invoke(new Action(Invalidate));
            else
                Invalidate();
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