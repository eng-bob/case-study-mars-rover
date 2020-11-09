using MarsRover.Library.Exceptions;
using MarsRover.Library.Model;
using MarsRover.Library.Model.Command;
using MarsRover.Library.Strategy;
using System;
using Xunit;

namespace MarsRover.Tests.Model.Command
{
    public class CommandFactoryShould
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
        public void ThrowInvalidCommandExceptionWhenCommandIsInvalid()
        {
            char command = 'E';

            var result = Record.Exception(() => CommandFactory.GetCommand(rover, command));

            Assert.NotNull(result);
            Assert.IsType<InvalidCommandException>(result);
        }
        [Theory]
        [InlineData('M', typeof(Move))]
        [InlineData('L', typeof(TurnLeft))]
        [InlineData('R', typeof(TurnRight))]
        public void ReturnCommandAccordingly(char command, Type expectedType)
        {
            var result = CommandFactory.GetCommand(rover, command);

            Assert.NotNull(result);
            Assert.Equal(expectedType, result.GetType());
        }
    }
}
