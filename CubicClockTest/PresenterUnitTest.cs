using CubicClock;
using CubicClock.Model;
using CubicClock.View;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace CubicClockTest
{
    [TestClass]
    public class PresenterUnitTest
    {
        private readonly Mock<IClock> _mockClock = new Mock<IClock>();
        private readonly Mock<IView> _mockView = new Mock<IView>();
        private Presenter _presenter;

        [TestInitialize]
        public void SetUp()
        {
            _presenter = new Presenter(_mockClock.Object);
            _presenter.Attach(_mockView.Object);
        }

        [TestMethod]
        public void given_view_attached_should_set_presenter_of_view()
        {
            _mockView.VerifySet(o => o.Presenter = _presenter, Times.Once());
        }

        [TestMethod]
        public void given_on_refresh_should_call_clock_update()
        {
            _presenter.OnRefresh();

            _mockClock.Verify(o => o.Update(), Times.Once());
        }

        [TestMethod]
        public void given_update_hour_should_update_hour_in_view()
        {
            _presenter.Hour = 12;

            _mockView.VerifySet(o => o.Hour = 12, Times.Once());
        }

        [TestMethod]
        public void given_update_minute_should_update_minute_in_view()
        {
            _presenter.Minute = 22;

            _mockView.VerifySet(o => o.Minute = 22, Times.Once());
        }
    }
}