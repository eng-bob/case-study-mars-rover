using MarsRover.Library.Model.Direction;
using Xunit;

namespace MarsRover.Tests.Model.Direction
{
    public class WestShould
    {
        [Fact]
        public void ReturnSameInstanceWhenGetInstanceIsCalledMoreThanOnce()
        {
            West westFirst = West.GetInstance();
            West westSecond = West.GetInstance();

            Assert.NotNull(westFirst);
            Assert.NotNull(westSecond);
            Assert.Same(westFirst, westSecond);
        }
        [Fact]
        public void ReturnSouthWhenGetLeftDirectionIsCalled()
        {
            West west = West.GetInstance();

            var result = west.GetLeftDirection();

            Assert.NotNull(result);
            Assert.IsType<South>(result);
        }
        [Fact]
        public void ReturnNorthWhenGetRightDirectionIsCalled()
        {
            West west = West.GetInstance();

            var result = west.GetRightDirection();

            Assert.NotNull(result);
            Assert.IsType<North>(result);
        }
        [Fact]
        public void ReturnMinusOneOnXAxisWhenGetMoveForwardCoordinatesIsCalled()
        {
            West west = West.GetInstance();

            var result = west.GetMoveForwardCoordinates();

            int expectedCoordX = -1;
            int expectedCoordY = 0;
            Assert.NotNull(result);
            Assert.Equal(expectedCoordX, result.coordX);
            Assert.Equal(expectedCoordY, result.coordY);
        }
    }
}
