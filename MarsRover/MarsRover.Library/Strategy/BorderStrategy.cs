using MarsRover.Library.Exceptions;
using MarsRover.Library.Model;
using MarsRover.Library.Model.Direction;

namespace MarsRover.Library.Strategy
{
    public abstract class BorderStrategy
    {
        protected Coordinates borderCoordinates;

        protected BorderStrategy(Coordinates borderCoordinates)
        {
            if (borderCoordinates.coordX < 0 || borderCoordinates.coordY < 0)
                throw new NegativeCoordException();

            this.borderCoordinates = borderCoordinates;
        }
        public abstract Coordinates MoveToNewCoordinates(Coordinates currentCoordinates, DirectionClass currentDirection);
    }
}
