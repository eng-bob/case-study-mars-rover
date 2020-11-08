using MarsRover.Library.Exceptions;
using MarsRover.Library.Model;
using MarsRover.Library.Strategy;
using Xunit;

namespace MarsRover.Tests.Model
{
    public class RoverShould
    {
        private static readonly int PlateauCoordX = 5;
        private static readonly int PlateauCoordY = 5;

        [Fact]
        public void ThrowNegativeCoordExceptionWhenGetNewRoverCoordinatesAreNegative()
        {
            int coordX = -1;
            int coordY = 0;
            char directionInfo = 'N';
            BorderStrategy borderStrategy = new WaitAtTheBorderStrategy(PlateauCoordX, PlateauCoordY);

            var result = Record.Exception(() => Rover.GetNewRover(coordX, coordY, directionInfo, borderStrategy));

            Assert.NotNull(result);
            Assert.IsType<NegativeCoordException>(result);
        }

        [Fact]
        public void ReturnNewRoverWhenParametersAreCorrect()
        {
            int coordX = 1;
            int coordY = 0;
            char directionInfo = 'N';
            BorderStrategy borderStrategy = new WaitAtTheBorderStrategy(PlateauCoordX, PlateauCoordY);

            var result = Rover.GetNewRover(coordX, coordY, directionInfo, borderStrategy);

            Assert.NotNull(result);
            Assert.Equal(directionInfo, result.GetDirection());
        }

        [Fact]
        public void MoveRoverForwardWhenMoveCommandIsGiven()
        {
            int coordX = 1;
            int coordY = 0;
            char directionInfo = 'N';
            BorderStrategy borderStrategy = new WaitAtTheBorderStrategy(PlateauCoordX, PlateauCoordY);
            var rover = Rover.GetNewRover(coordX, coordY, directionInfo, borderStrategy);

            rover.Move();

            Coordinates expectedCoordinates = new Coordinates(1, 1);
            Assert.Equal(expectedCoordinates.coordX, rover.currentCoordinates.coordX);
            Assert.Equal(expectedCoordinates.coordY, rover.currentCoordinates.coordY);
        }

        [Fact]
        public void TurnLeftWhenTurnLeftIsCalled()
        {
            int coordX = 1;
            int coordY = 0;
            char directionInfo = 'N';
            BorderStrategy borderStrategy = new WaitAtTheBorderStrategy(PlateauCoordX, PlateauCoordY);
            var rover = Rover.GetNewRover(coordX, coordY, directionInfo, borderStrategy);

            rover.TurnLeft();

            char expectedDirection = 'W';
            Assert.Equal(expectedDirection, rover.GetDirection());
        }

        [Fact]
        public void TurnRightWhenTurnRightIsCalled()
        {
            int coordX = 1;
            int coordY = 0;
            char directionInfo = 'N';
            BorderStrategy borderStrategy = new WaitAtTheBorderStrategy(PlateauCoordX, PlateauCoordY);
            var rover = Rover.GetNewRover(coordX, coordY, directionInfo, borderStrategy);

            rover.TurnRight();

            char expectedDirection = 'E';
            Assert.Equal(expectedDirection, rover.GetDirection());
        }
    }
}
