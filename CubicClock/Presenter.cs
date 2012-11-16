namespace CubicClock
{
    public class Presenter
    {
        private readonly IClock _clock;
        private IView _view;

        public Presenter(IClock clock)
        {
            _clock = clock;
        }

        public int Hour
        {
            set { _view.Hour = value; }
        }

        public void Attach(IView view)
        {
            view.Presenter = this;
            _view = view;
        }

        public void OnRefresh()
        {
            _clock.Update();
        }
    }
}