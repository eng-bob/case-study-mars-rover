using System;

namespace MarsRover.Library.Exceptions
{
    [Serializable]
    public class OutOfPlateauException : Exception
    {
        public OutOfPlateauException() : base(Resources.OutOfPlateauExceptionMessage)
        {

        }
    }
}
