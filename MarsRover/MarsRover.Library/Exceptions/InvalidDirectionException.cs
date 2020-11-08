using System;

namespace MarsRover.Library.Exceptions
{
    public class InvalidDirectionException : Exception
    {
        public InvalidDirectionException() : base(Resources.InvalidDirectionExceptionMessage)
        {

        }
    }
}
