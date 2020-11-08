using MarsRover.Library.Enum;
using MarsRover.Library.Exceptions;

namespace MarsRover.Library.Model.Direction
{
    public class DirectionFactory
    {
        /// <summary>
        /// Factory method that returns direction according to given directionCode char
        /// </summary>
        /// <param name="directionCode">directionCode char</param>
        /// <returns>Direction object</returns>
        public static DirectionClass GetDirection(char directionCode)
        {
            switch (directionCode)
            {
                case (char)Directions.North:
                    return North.GetInstance();
                case (char)Directions.East:
                    return East.GetInstance();
                case (char)Directions.South:
                    return South.GetInstance();
                case (char)Directions.West:
                    return West.GetInstance();
                default:
                    throw new InvalidDirectionException();
            }
        }
    }
}
