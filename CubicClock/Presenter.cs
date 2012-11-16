using System;

namespace CubicClock
{
    public class Presenter
    {
        private readonly IClock _clock;

        public Presenter(IClock clock)
        {
            _clock = clock;
        }

        public void Attach(IView view)
        {
            view.Presenter = this;
        }

        public void OnRefresh()
        {
            _clock.Update();
        }
    }
}