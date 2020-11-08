using MarsRover.Library.Enum;

namespace MarsRover.Library.Model.Direction
{
    public class North : DirectionClass
    {
        private static North _instance;
        private North()
        {
            direction = Directions.North;
        }

        /// <summary>
        /// Returns left direction of current DirectionClass
        /// </summary>
        /// <returns>DirectionClass object</returns>
        public override DirectionClass GetLeftDirection()
        {
            return West.GetInstance();
        }
        /// <summary>
        /// Returns right direction of current DirectionClass
        /// </summary>
        /// <returns>DirectionClass object</returns>
        public override DirectionClass GetRightDirection()
        {
            return East.GetInstance();
        }
        /// <summary>
        /// Returns instance of the object according to Singleton Design Pattern
        /// </summary>
        /// <returns>Instance of the object</returns>
        public static North GetInstance()
        {
            if (_instance == null)
                _instance = new North();
            return _instance;
        }

        /// <summary>
        /// Returns step Coordinates object to move forward to
        /// </summary>
        /// <returns>Coordinates object</returns>
        public override Coordinates GetMoveForwardCoordinates()
        {
            return new Coordinates { coordY = 1 };
        }
    }
}
