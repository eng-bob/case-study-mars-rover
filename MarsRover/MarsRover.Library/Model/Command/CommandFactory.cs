using MarsRover.Library.Enum;
using MarsRover.Library.Exceptions;

namespace MarsRover.Library.Model.Command
{
    public class CommandFactory
    {
        /// <summary>
        /// Factory method that returns command according to given command char
        /// </summary>
        /// <param name="rover">Rover object to associate with given command</param>
        /// <param name="command">Command char</param>
        /// <returns>Command object associated with given rover and command char</returns>
        public static ICommand GetCommand(Rover rover, char command)
        {
            switch (command)
            {
                case (char)Commands.Move:
                    return new Move(rover);
                case (char)Commands.TurnLeft:
                    return new TurnLeft(rover);
                case (char)Commands.TurnRight:
                    return new TurnRight(rover);
                default:
                    throw new InvalidCommandException();
            }
        }
    }
}
