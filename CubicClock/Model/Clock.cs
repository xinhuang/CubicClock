using System;
using System.Threading;

namespace CubicClock.Model
{
    public class Clock : IClock
    {
        private IClockEvents _presenter;

        #region IClock Members

        public void Attach(IClockEvents presenter)
        {
            _presenter = presenter;
        }

        public void Update()
        {
            _presenter.Hour = DateTime.Now.Hour;
            _presenter.Minute = DateTime.Now.Minute;
            _presenter.Second = DateTime.Now.Second;
        }

        public void Start()
        {
            new Thread(() =>
                        {
                            while (true)
                            {
                                Thread.Sleep(1000);
                                Update();
                            }
                        }) { IsBackground = true }.Start();
        }

        #endregion
    }
}