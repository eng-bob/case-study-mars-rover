using System;

namespace MarsRover.Library.Exceptions
{
    public class InvalidPlateauBorderCoordinatesException : Exception
    {
        public InvalidPlateauBorderCoordinatesException() : base(Resources.InvalidPlateauBorderCoordinatesExceptionMessage)
        {

        }
    }
}
