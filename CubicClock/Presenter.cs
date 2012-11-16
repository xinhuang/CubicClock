using CubicClock.Model;
using CubicClock.View;

namespace CubicClock
{
    public class Presenter : IViewEvents, IClockEvents
    {
        private readonly IClock _clock;
        private IView _view;

        public Presenter(IClock clock)
        {
            _clock = clock;
            _clock.Attach(this);
        }

        #region IClockEvents Members

        public int Hour
        {
            set { _view.Hour = value; }
        }

        public int Minute
        {
            set { _view.Minute = value; }
        }

        public int Second
        {
            set { _view.Second = value; }
        }

        #endregion

        #region IViewEvents Members

        public void OnRefresh()
        {
            _clock.Update();
        }

        #endregion

        public void Attach(IView view)
        {
            _view = view;
            _view.Presenter = this;
            _clock.Start();
        }
    }
}