using MarsRover.Library.Model;
using MarsRover.Library.Model.Command;
using MarsRover.Library.Strategy;
using Xunit;

namespace MarsRover.Tests.Model.Command
{
    public class TurnLeftShould
    {
        private static readonly int plateauCoordX = 5;
        private static readonly int plateauCoordY = 5;
        private static readonly int roverCoordX = 0;
        private static readonly int roverCoordY = 0;
        private static readonly char directionInfo = 'N';
        private static readonly BorderStrategy borderStrategy = new WaitAtTheBorderStrategy(plateauCoordX, plateauCoordY);
        private static readonly Rover rover = Rover.GetNewRover(roverCoordX, roverCoordY, directionInfo, borderStrategy);

        [Fact]
        public void TurnRoverLeftWhenExecuteIsCalled()
        {
            TurnLeft turnLeftCommand = new TurnLeft(rover);

            turnLeftCommand.Execute();

            int expectedCoordX = 0;
            int expectedCoordY = 0;
            char expectedDirectionInfo = 'W';
            Assert.Equal(expectedCoordX, rover.currentCoordinates.coordX);
            Assert.Equal(expectedCoordY, rover.currentCoordinates.coordY);
            Assert.Equal(expectedDirectionInfo, rover.GetDirection());
        }
    }
}
