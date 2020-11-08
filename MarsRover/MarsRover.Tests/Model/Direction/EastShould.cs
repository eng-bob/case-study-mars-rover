using MarsRover.Library.Model.Direction;
using Xunit;

namespace MarsRover.Tests.Model.Direction
{
    public class EastShould
    {
        [Fact]
        public void ReturnSameInstanceWhenGetInstanceIsCalledMoreThanOnce()
        {
            East eastFirst = East.GetInstance();
            East eastSecond = East.GetInstance();

            Assert.NotNull(eastFirst);
            Assert.NotNull(eastSecond);
            Assert.Same(eastFirst, eastSecond);
        }
        [Fact]
        public void ReturnNorthWhenGetLeftDirectionIsCalled()
        {
            East east = East.GetInstance();

            var result = east.GetLeftDirection();

            Assert.NotNull(result);
            Assert.IsType<North>(result);
        }
        [Fact]
        public void ReturnSouthWhenGetRightDirectionIsCalled()
        {
            East east = East.GetInstance();

            var result = east.GetRightDirection();

            Assert.NotNull(result);
            Assert.IsType<South>(result);
        }
        [Fact]
        public void ReturnPlusOneOnXAxisWhenGetMoveForwardCoordinatesIsCalled()
        {
            East east = East.GetInstance();

            var result = east.GetMoveForwardCoordinates();

            int expectedCoordX = 1;
            int expectedCoordY = 0;
            Assert.NotNull(result);
            Assert.Equal(expectedCoordX, result.coordX);
            Assert.Equal(expectedCoordY, result.coordY);
        }
    }
}
