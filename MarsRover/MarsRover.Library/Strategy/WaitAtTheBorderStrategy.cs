using MarsRover.Library.Model;
using MarsRover.Library.Model.Direction;

namespace MarsRover.Library.Strategy
{
    public class WaitAtTheBorderStrategy : BorderStrategy
    {
        public WaitAtTheBorderStrategy(int coordX, int coordY) : base(new Coordinates(coordX, coordY))
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

            if (newCoordinates.coordX < 0)
                newCoordinates.coordX = 0;
            if (newCoordinates.coordX > borderCoordinates.coordX)
                newCoordinates.coordX = borderCoordinates.coordX;
            if (newCoordinates.coordY < 0)
                newCoordinates.coordY = 0;
            if (newCoordinates.coordY > borderCoordinates.coordY)
                newCoordinates.coordY = borderCoordinates.coordY;

            return newCoordinates;
        }
    }
}
