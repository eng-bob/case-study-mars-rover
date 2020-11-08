using System;

namespace MarsRover.Library.Exceptions
{
    [Serializable]
    public class InvalidCommandException : Exception
    {
        public InvalidCommandException() : base(Resources.InvalidCommandExceptionMessage)
        {

        }
    }
}
