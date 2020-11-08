using System;

namespace MarsRover.Library.Exceptions
{
    [Serializable]
    public class NegativeCoordException : Exception
    {
        public NegativeCoordException() : base(Resources.NegativeCoordExceptionMessage)
        {

        }
    }
}
