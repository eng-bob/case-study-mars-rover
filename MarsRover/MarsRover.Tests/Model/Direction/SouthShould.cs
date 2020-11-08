using MarsRover.Library.Model.Direction;
using Xunit;

namespace MarsRover.Tests.Model.Direction
{
    public class SouthShould
    {
        [Fact]
        public void ReturnSameInstanceWhenGetInstanceIsCalledMoreThanOnce()
        {
            South southFirst = South.GetInstance();
            South southSecond = South.GetInstance();

            Assert.NotNull(southFirst);
            Assert.NotNull(southSecond);
            Assert.Same(southFirst, southSecond);
        }
        [Fact]
        public void ReturnEastWhenGetLeftDirectionIsCalled()
        {
            South south = South.GetInstance();

            var result = south.GetLeftDirection();

            Assert.NotNull(result);
            Assert.IsType<East>(result);
        }
        [Fact]
        public void ReturnWestWhenGetRightDirectionIsCalled()
        {
            South south = South.GetInstance();

            var result = south.GetRightDirection();

            Assert.NotNull(result);
            Assert.IsType<West>(result);
        }
        [Fact]
        public void ReturnMinusOneOnYAxisWhenGetMoveForwardCoordinatesIsCalled()
        {
            South south = South.GetInstance();

            var result = south.GetMoveForwardCoordinates();

            int expectedCoordX = 0;
            int expectedCoordY = -1;
            Assert.NotNull(result);
            Assert.Equal(expectedCoordX, result.coordX);
            Assert.Equal(expectedCoordY, result.coordY);
        }
    }
}
