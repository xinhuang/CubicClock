using System;

namespace CubicClock.Model
{
    public class Clock : IClock
    {
        private IClockEvents _presenter;

        public void Attach(IClockEvents presenter)
        {
            _presenter = presenter;
        }

        public void Update()
        {
            _presenter.Hour = DateTime.Now.Hour;
            _presenter.Minute = DateTime.Now.Minute;
        }
    }
}