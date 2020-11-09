﻿using MarsRover.Library.Exceptions;
using MarsRover.Library.Model;
using MarsRover.Library.Model.Direction;
using MarsRover.Library.Strategy;
using Xunit;

namespace MarsRover.Tests.Strategy
{
    public class ThrowExceptionBorderStrategyShould
    {
        private static readonly int plateauLowerCoordX = 0;
        private static readonly int plateauLowerCoordY = 0;
        private static readonly int plateauUpperCoordX = 5;
        private static readonly int plateauUpperCoordY = 5;
        private static readonly Coordinates coordinates = new Coordinates(0, 0);
        private static readonly BorderStrategy borderStrategy = new ThrowExceptionBorderStrategy(plateauLowerCoordX, plateauLowerCoordY, plateauUpperCoordX, plateauUpperCoordY);

        [Fact]
        public void ThrowInvalidPlateauBorderCoordinatesExceptionWhenCoordinatesAreInvalid()
        {
            var result = Record.Exception(() => new ThrowExceptionBorderStrategy(0, 1, 0, 0));

            Assert.NotNull(result);
            Assert.IsType<InvalidPlateauBorderCoordinatesException>(result);
        }
        [Fact]
        public void ThrowOutOfPlateauExceptionWhenMoveToNewCoordinatesExceedsBorders()
        {
            DirectionClass direction = DirectionFactory.GetDirection('S');

            var result = Record.Exception(() => borderStrategy.MoveToNewCoordinates(coordinates, direction));

            Assert.NotNull(result);
            Assert.IsType<OutOfPlateauException>(result);
        }
        [Fact]
        public void MoveToCoordinatesWhenMoveToNewCoordinatesStaysInBorders()
        {
            DirectionClass direction = DirectionFactory.GetDirection('N');

            var result = borderStrategy.MoveToNewCoordinates(coordinates, direction);

            int expectedCoordX = 0;
            int expectedCoordY = 1;
            Assert.NotNull(result);
            Assert.Equal(expectedCoordX, result.coordX);
            Assert.Equal(expectedCoordY, result.coordY);
        }
    }
}
