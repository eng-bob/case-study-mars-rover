using MarsRover.Library.Exceptions;
using MarsRover.Library.Model.Direction;
using System;
using Xunit;

namespace MarsRover.Tests.Model.Direction
{
    public class DirectionFactoryShould
    {
        [Fact]
        public void ThrowInvalidDirectionExceptionWhenDirectionInfoIsInvalid()
        {
            char directionInfo = 'X';

            var result = Record.Exception(() => DirectionFactory.GetDirection(directionInfo));

            Assert.NotNull(result);
            Assert.IsType<InvalidDirectionException>(result);
        }
        [Theory]
        [InlineData('N', typeof(North))]
        [InlineData('E', typeof(East))]
        [InlineData('S', typeof(South))]
        [InlineData('W', typeof(West))]
        public void ReturnDirectionAccordingly(char directionInfo, Type expectedType)
        {
            var result = DirectionFactory.GetDirection(directionInfo);

            Assert.NotNull(result);
            Assert.Equal(expectedType, result.GetType());
        }
    }
}
