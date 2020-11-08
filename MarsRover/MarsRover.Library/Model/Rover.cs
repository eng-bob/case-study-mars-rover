using MarsRover.Library.Exceptions;
using MarsRover.Library.Model.Direction;
using MarsRover.Library.Strategy;

namespace MarsRover.Library.Model
{
    public class Rover
    {
        private DirectionClass currentDirection;
        private BorderStrategy chosenBorderStrategy;
        public Coordinates currentCoordinates { get; set; }

        private Rover()
        {

        }

        /// <summary>
        /// Returns new instance of a Rover object
        /// </summary>
        /// <param name="coordX">Rover's starting coordinate on the X axis</param>
        /// <param name="coordY">Rover's starting coordinate on the Y axis</param>
        /// <param name="directionInfo">Rover's facing direction</param>
        /// <param name="chosenBorderStrategy">Chosen BorderStrategy for the Rover</param>
        /// <returns>New instance of a Rover object</returns>
        public static Rover GetNewRover(int coordX, int coordY, char directionInfo, BorderStrategy chosenBorderStrategy)
        {
            if (coordX < 0 || coordY < 0)
                throw new NegativeCoordException();

            Rover NewRover = new Rover
            {
                currentDirection = DirectionFactory.GetDirection(directionInfo),
                chosenBorderStrategy = chosenBorderStrategy,
                currentCoordinates = new Coordinates(coordX, coordY)
            };

            return NewRover;
        }
        /// <summary>
        /// Returns current direction of the Rover
        /// </summary>
        /// <returns>Direction code char</returns>
        public char GetDirection()
        {
            return (char)currentDirection.direction;
        }
        /// <summary>
        /// Moves the Rover to the new Coordinates according to facing direction and chosen border strategy
        /// </summary>
        public void Move()
        {
            currentCoordinates = chosenBorderStrategy.MoveToNewCoordinates(currentCoordinates, currentDirection);
        }
        /// <summary>
        /// Turns the Rover 90 degrees to left
        /// </summary>
        public void TurnLeft()
        {
            currentDirection = currentDirection.GetLeftDirection();
        }
        /// <summary>
        /// Turns the Rover 90 degrees to right
        /// </summary>
        public void TurnRight()
        {
            currentDirection = currentDirection.GetRightDirection();
        }
    }
}
