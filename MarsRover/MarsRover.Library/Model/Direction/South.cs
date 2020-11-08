using MarsRover.Library.Enum;

namespace MarsRover.Library.Model.Direction
{
    public class South : DirectionClass
    {
        private static South _instance;
        private South()
        {
            direction = Directions.South;
        }

        /// <summary>
        /// Returns left direction of current DirectionClass
        /// </summary>
        /// <returns>DirectionClass object</returns>
        public override DirectionClass GetLeftDirection()
        {
            return East.GetInstance();
        }
        /// <summary>
        /// Returns right direction of current DirectionClass
        /// </summary>
        /// <returns>DirectionClass object</returns>
        public override DirectionClass GetRightDirection()
        {
            return West.GetInstance();
        }
        /// <summary>
        /// Returns instance of the object according to Singleton Design Pattern
        /// </summary>
        /// <returns>Instance of the object</returns>
        public static South GetInstance()
        {
            if (_instance == null)
                _instance = new South();
            return _instance;
        }

        /// <summary>
        /// Returns step Coordinates object to move forward to
        /// </summary>
        /// <returns>Coordinates object</returns>
        public override Coordinates GetMoveForwardCoordinates()
        {
            return new Coordinates { coordY = -1 };
        }
    }
}
