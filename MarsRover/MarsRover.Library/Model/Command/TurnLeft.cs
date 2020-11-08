namespace MarsRover.Library.Model.Command
{
    public class TurnLeft : ICommand
    {
        private Rover rover;

        public TurnLeft(Rover rover)
        {
            this.rover = rover;
        }
        /// <summary>
        /// Calls associated Rover's TurnLeft method
        /// </summary>
        public void Execute()
        {
            rover.TurnLeft();
        }
    }
}
