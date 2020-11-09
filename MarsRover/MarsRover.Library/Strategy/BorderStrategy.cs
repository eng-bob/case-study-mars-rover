using MarsRover.Library.Exceptions;
using MarsRover.Library.Model;
using MarsRover.Library.Model.Direction;

namespace MarsRover.Library.Strategy
{
    public abstract class BorderStrategy
    {
        public Coordinates lowerBoundryBorderCoordinates { get; set; }
        public Coordinates upperBoundryBorderCoordinates { get; set; }

        protected BorderStrategy(Coordinates lowerBoundryBorderCoordinates, Coordinates upperBoundryBorderCoordinates)
        {
            if (upperBoundryBorderCoordinates.coordX < lowerBoundryBorderCoordinates.coordX || upperBoundryBorderCoordinates.coordY < lowerBoundryBorderCoordinates.coordY)
                throw new InvalidPlateauBorderCoordinatesException();

            this.lowerBoundryBorderCoordinates = lowerBoundryBorderCoordinates;
            this.upperBoundryBorderCoordinates = upperBoundryBorderCoordinates;
        }
        public abstract Coordinates MoveToNewCoordinates(Coordinates currentCoordinates, DirectionClass currentDirection);
    }
}
