using MarsRover.Library.Model.Direction;
using Xunit;

namespace MarsRover.Tests.Model.Direction
{
    public class NorthShould
    {
        [Fact]
        public void ReturnSameInstanceWhenGetInstanceIsCalledMoreThanOnce()
        {
            North northFirst = North.GetInstance();
            North northSecond = North.GetInstance();

            Assert.NotNull(northFirst);
            Assert.NotNull(northSecond);
            Assert.Same(northFirst, northSecond);
        }
        [Fact]
        public void ReturnWestWhenGetLeftDirectionIsCalled()
        {
            North north = North.GetInstance();

            var result = north.GetLeftDirection();

            Assert.NotNull(result);
            Assert.IsType<West>(result);
        }
        [Fact]
        public void ReturnEastWhenGetRightDirectionIsCalled()
        {
            North north = North.GetInstance();

            var result = north.GetRightDirection();

            Assert.NotNull(result);
            Assert.IsType<East>(result);
        }
        [Fact]
        public void ReturnPlusOneOnYAxisWhenGetMoveForwardCoordinatesIsCalled()
        {
            North north = North.GetInstance();

            var result = north.GetMoveForwardCoordinates();

            int expectedCoordX = 0;
            int expectedCoordY = 1;
            Assert.NotNull(result);
            Assert.Equal(expectedCoordX, result.coordX);
            Assert.Equal(expectedCoordY, result.coordY);
        }
    }
}
