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

        public int Max { get; set; }

        public int Value
        {
            get { return _value; }
            set
            {
                _value = value;
                Update();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            var blackRegion = new RectangleF(0, 0, Value/Max*Width, Height);
            using (var blackBrush = new SolidBrush(Color.Black))
            {
                e.Graphics.FillRectangle(blackBrush, blackRegion);
            }
        }
    }
}