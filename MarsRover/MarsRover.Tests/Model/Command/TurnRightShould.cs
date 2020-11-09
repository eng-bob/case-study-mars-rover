﻿using MarsRover.Library.Model;
using MarsRover.Library.Model.Command;
using MarsRover.Library.Strategy;
using Xunit;

namespace MarsRover.Tests.Model.Command
{
    public class TurnRightShould
    {
        private static readonly int plateauLowerCoordX = 0;
        private static readonly int plateauLowerCoordY = 0;
        private static readonly int plateauUpperCoordX = 5;
        private static readonly int plateauUpperCoordY = 5;
        private static readonly int roverCoordX = 0;
        private static readonly int roverCoordY = 0;
        private static readonly char directionInfo = 'N';
        private static readonly BorderStrategy borderStrategy = new WaitAtTheBorderStrategy(plateauLowerCoordX, plateauLowerCoordY, plateauUpperCoordX, plateauUpperCoordY);
        private static readonly Rover rover = Rover.GetNewRover(roverCoordX, roverCoordY, directionInfo, borderStrategy);

        [Fact]
        public void TurnRoverRightWhenExecuteIsCalled()
        {
            TurnRight turnRightCommand = new TurnRight(rover);

            turnRightCommand.Execute();

            int expectedCoordX = 0;
            int expectedCoordY = 0;
            char expectedDirectionInfo = 'E';
            Assert.Equal(expectedCoordX, rover.currentCoordinates.coordX);
            Assert.Equal(expectedCoordY, rover.currentCoordinates.coordY);
            Assert.Equal(expectedDirectionInfo, rover.GetDirection());
        }
    }
}
