namespace MarsRover.Library.Model.Command
{
    public class TurnRight : ICommand
    {
        private Rover rover;

        public TurnRight(Rover rover)
        {
            this.rover = rover;
        }
        /// <summary>
        /// Calls associated Rover's TurnRight method
        /// </summary>
        public void Execute()
        {
            rover.TurnRight();
        }
    }
}
