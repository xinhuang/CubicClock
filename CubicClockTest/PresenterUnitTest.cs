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
        public void given_view_attached_should_set_presenter_of_view_and_start_clock()
        {
            _mockView.VerifySet(o => o.Presenter = _presenter, Times.Once());
            _mockClock.Verify(o => o.Start(), Times.Once());
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

        [TestMethod]
        public void given_update_second_should_update_second_in_view()
        {
            _presenter.Second = 44;

            _mockView.VerifySet(o => o.Second = 44, Times.Once());
        }

        [TestMethod]
        public void given_top_most_checked_should_view_set_to_top_most()
        {
            _presenter.OnTopMostCheckChanged(true);

            _mockView.VerifySet(o => o.TopMost = true, Times.Once());
        }

        [TestMethod]
        public void given_hide_in_task_bar_should_view_show_in_task_bar_be_set_to_false()
        {
            _presenter.OnShowInTaskBarChanged(false);

            _mockView.VerifySet(o => o.ShowInTaskBar = false, Times.Once());
        }
    }
}