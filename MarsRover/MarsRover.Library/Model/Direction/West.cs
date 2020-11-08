using MarsRover.Library.Enum;

namespace MarsRover.Library.Model.Direction
{
    public class West : DirectionClass
    {
        private static West _instance;
        private West()
        {
            direction = Directions.West;
        }

        /// <summary>
        /// Returns left direction of current DirectionClass
        /// </summary>
        /// <returns>DirectionClass object</returns>
        public override DirectionClass GetLeftDirection()
        {
            return South.GetInstance();
        }
        /// <summary>
        /// Returns right direction of current DirectionClass
        /// </summary>
        /// <returns>DirectionClass object</returns>
        public override DirectionClass GetRightDirection()
        {
            return North.GetInstance();
        }
        /// <summary>
        /// Returns instance of the object according to Singleton Design Pattern
        /// </summary>
        /// <returns>Instance of the object</returns>
        public static West GetInstance()
        {
            if (_instance == null)
                _instance = new West();
            return _instance;
        }

        /// <summary>
        /// Returns step Coordinates object to move forward to
        /// </summary>
        /// <returns>Coordinates object</returns>
        public override Coordinates GetMoveForwardCoordinates()
        {
            return new Coordinates { coordX = -1 };
        }
    }
}
