using MarsRover.Library.Exceptions;
using MarsRover.Library.Model;
using MarsRover.Library.Model.Direction;

namespace MarsRover.Library.Strategy
{
    public class ThrowExceptionBorderStrategy : BorderStrategy
    {
        public ThrowExceptionBorderStrategy(int coordX, int coordY) : base(new Coordinates(coordX, coordY))
        {

        }
        /// <summary>
        /// Throws OutOfPlateauException if the Rover tries to move out of the plateau borders, else returns new Coordinates to move
        /// </summary>
        /// <param name="currentCoordinates">Rover's current coordinates</param>
        /// <param name="currentDirection">Rover's current direction</param>
        /// <returns>New Coordinates to move according to given direction</returns>
        public override Coordinates MoveToNewCoordinates(Coordinates currentCoordinates, DirectionClass currentDirection)
        {
            Coordinates newCoordinates = currentCoordinates + currentDirection.GetMoveForwardCoordinates();

            if (newCoordinates.coordX < 0 || newCoordinates.coordY < 0 || newCoordinates.coordX > borderCoordinates.coordX || newCoordinates.coordY > borderCoordinates.coordY)
                throw new OutOfPlateauException();

            return newCoordinates;
        }
    }
}
