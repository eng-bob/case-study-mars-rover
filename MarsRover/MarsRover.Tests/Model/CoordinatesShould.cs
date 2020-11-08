using MarsRover.Library.Model;
using Xunit;

namespace MarsRover.Tests.Model
{
    public class CoordinatesShould
    {
        [Fact]
        public void ReturnDefaultCoordinatesWhenDefaultCalled()
        {
            int coordX = 1;
            int coordY = 1;

            Coordinates coordinates = new Coordinates();
            Coordinates coordinatesX = new Coordinates { coordX = coordX };
            Coordinates coordinatesY = new Coordinates { coordY = coordY };

            Assert.NotNull(coordinates);
            Assert.NotNull(coordinatesX);
            Assert.NotNull(coordinatesY);
            Assert.Equal(0, coordinates.coordX);
            Assert.Equal(0, coordinates.coordY);
            Assert.Equal(coordX, coordinatesX.coordX);
            Assert.Equal(0, coordinatesX.coordY);
            Assert.Equal(0, coordinatesY.coordX);
            Assert.Equal(coordY, coordinatesY.coordY);
        }
        [Fact]
        public void ReturnSumOfCoordinatesWhenAdditionOperatorCalled()
        {
            int coordX1 = 1;
            int coordY1 = 0;
            int coordX2 = 3;
            int coordY2 = 1;
            Coordinates coord1 = new Coordinates(coordX1, coordY1);
            Coordinates coord2 = new Coordinates(coordX2, coordY2);

            var result = coord1 + coord2;

            int expectedX = coordX1 + coordX2;
            int expectedY = coordY1 + coordY2;
            Assert.NotNull(result);
            Assert.Equal(expectedX, result.coordX);
            Assert.Equal(expectedY, result.coordY);
        }
    }
}
