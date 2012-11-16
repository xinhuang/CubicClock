using CubicClock;
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
        }

        [TestMethod]
        public void given_view_attached_should_set_presenter_of_view()
        {
            _presenter.Attach(_mockView.Object);

            _mockView.VerifySet(o => o.Presenter = _presenter, Times.Once());
        }

        [TestMethod]
        public void given_on_refresh_should_call_clock_update()
        {
            _presenter.OnRefresh();

            _mockClock.Verify(o => o.Update(), Times.Once());
        }
    }
}