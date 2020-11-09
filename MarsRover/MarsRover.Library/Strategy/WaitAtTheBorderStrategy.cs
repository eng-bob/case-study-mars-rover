using MarsRover.Library.Model;
using MarsRover.Library.Model.Direction;

namespace MarsRover.Library.Strategy
{
    public class WaitAtTheBorderStrategy : BorderStrategy
    {
        public WaitAtTheBorderStrategy(int lowerBoundryCoordX, int lowerBoundryCoordY, int upperBoundryCoordX, int upperBoundryCoordY) : base(new Coordinates(lowerBoundryCoordX, lowerBoundryCoordY), new Coordinates(upperBoundryCoordX, upperBoundryCoordY))
        {

        }
        /// <summary>
        /// Makes the Rover wait if it tries to move out of the plateau borders, else returns new Coordinates to move
        /// </summary>
        /// <param name="currentCoordinates">Rover's current coordinates</param>
        /// <param name="currentDirection">Rover's current direction</param>
        /// <returns>New Coordinates to move according to given direction</returns>
        public override Coordinates MoveToNewCoordinates(Coordinates currentCoordinates, DirectionClass currentDirection)
        {
            Coordinates newCoordinates = currentCoordinates + currentDirection.GetMoveForwardCoordinates();

            if (newCoordinates.coordX < lowerBoundryBorderCoordinates.coordX)
                newCoordinates.coordX = lowerBoundryBorderCoordinates.coordX;
            if (newCoordinates.coordX > upperBoundryBorderCoordinates.coordX)
                newCoordinates.coordX = upperBoundryBorderCoordinates.coordX;
            if (newCoordinates.coordY < lowerBoundryBorderCoordinates.coordY)
                newCoordinates.coordY = lowerBoundryBorderCoordinates.coordY;
            if (newCoordinates.coordY > upperBoundryBorderCoordinates.coordY)
                newCoordinates.coordY = upperBoundryBorderCoordinates.coordY;

            return newCoordinates;
        }
    }
}
