namespace CubicClock
{
    public class Presenter : IViewEvents, IClockEvents
    {
        private readonly IClock _clock;
        private IView _view;

        public Presenter(IClock clock)
        {
            _clock = clock;
        }

        #region IClockEvents Members

        public int Hour
        {
            set { _view.Hour = value; }
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
            view.Presenter = this;
            _view = view;
        }
    }
}