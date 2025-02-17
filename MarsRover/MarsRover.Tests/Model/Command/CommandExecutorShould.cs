﻿using MarsRover.Library.Model;
using MarsRover.Library.Model.Command;
using MarsRover.Library.Strategy;
using Xunit;

namespace MarsRover.Tests.Model.Command
{
    public class CommandExecutorShould
    {
        private static readonly int plateauLowerCoordX = 0;
        private static readonly int plateauLowerCoordY = 0;
        private static readonly int plateauUpperCoordX = 5;
        private static readonly int plateauUpperCoordY = 5;
        private static readonly int roverCoordX = 1;
        private static readonly int roverCoordY = 2;
        private static readonly char directionInfo = 'N';
        private static readonly BorderStrategy borderStrategy = new WaitAtTheBorderStrategy(plateauLowerCoordX, plateauLowerCoordY, plateauUpperCoordX, plateauUpperCoordY);
        private static readonly Rover rover = Rover.GetNewRover(roverCoordX, roverCoordY, directionInfo, borderStrategy);

        [Theory]
        [InlineData("LMLMLMLMM", 1, 3, 'N')]
        public void ExecuteAllCommandsWhenExecuteCommandsIsCalled(string commands, int expectedCoordX, int expectedCoordY, char expectedDirectionInfo)
        {
            CommandExecutor.ExecuteCommands(rover, commands);

            Assert.Equal(expectedCoordX, rover.currentCoordinates.coordX);
            Assert.Equal(expectedCoordY, rover.currentCoordinates.coordY);
            Assert.Equal(expectedDirectionInfo, rover.GetDirection());
        }
    }
}
