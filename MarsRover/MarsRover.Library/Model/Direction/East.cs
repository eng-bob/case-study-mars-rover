using MarsRover.Library.Enum;

namespace MarsRover.Library.Model.Direction
{
    public class East : DirectionClass
    {
        private static East _instance;
        private East()
        {
            direction = Directions.East;
        }

        /// <summary>
        /// Returns left direction of current DirectionClass
        /// </summary>
        /// <returns>DirectionClass object</returns>
        public override DirectionClass GetLeftDirection()
        {
            return North.GetInstance();
        }
        /// <summary>
        /// Returns right direction of current DirectionClass
        /// </summary>
        /// <returns>DirectionClass object</returns>
        public override DirectionClass GetRightDirection()
        {
            return South.GetInstance();
        }
        /// <summary>
        /// Returns instance of the object according to Singleton Design Pattern
        /// </summary>
        /// <returns>Instance of the object</returns>
        public static East GetInstance()
        {
            if (_instance == null)
                _instance = new East();
            return _instance;
        }

        /// <summary>
        /// Returns step Coordinates object to move forward to
        /// </summary>
        /// <returns>Coordinates object</returns>
        public override Coordinates GetMoveForwardCoordinates()
        {
            return new Coordinates { coordX = 1 };
        }
    }
}
