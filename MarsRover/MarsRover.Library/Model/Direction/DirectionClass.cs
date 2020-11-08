using MarsRover.Library.Enum;

namespace MarsRover.Library.Model.Direction
{
    public abstract class DirectionClass
    {
        public Directions direction { get; set; }

        public abstract Coordinates GetMoveForwardCoordinates();
        public abstract DirectionClass GetLeftDirection();
        public abstract DirectionClass GetRightDirection();
    }
}
