using CubicClock.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace CubicClockTest
{
    [TestClass]
    public class ClockUnitTest
    {
        private Clock _sut;
        private readonly Mock<IClockEvents> _mockPresenter = new Mock<IClockEvents>();

        [TestInitialize]
        public void SetUp()
        {
            _sut = new Clock();
            _sut.Attach(_mockPresenter.Object);
        }

        [TestMethod]
        public void given_update_should_update_presenter()
        {
            _sut.Update();

            _mockPresenter.VerifySet(o => o.Hour = It.IsAny<int>(), Times.Once());
            _mockPresenter.VerifySet(o => o.Minute = It.IsAny<int>(), Times.Once());
        }
    }
}
