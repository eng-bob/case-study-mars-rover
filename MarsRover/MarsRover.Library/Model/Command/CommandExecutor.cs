namespace MarsRover.Library.Model.Command
{
    public class CommandExecutor
    {
        /// <summary>
        /// Executes command sequence on given rover
        /// </summary>
        /// <param name="rover">Rover object to execute commands on</param>
        /// <param name="commandString">Command sequence to execute</param>
        public static void ExecuteCommands(Rover rover, string commandString)
        {
            foreach (var command in commandString)
            {
                CommandFactory.GetCommand(rover, command).Execute();
            }
        }
    }
}
