namespace MarsRover.Library.Model.Command
{
    public class Move : ICommand
    {
        private Rover rover;

        public Move(Rover rover)
        {
            this.rover = rover;
        }
        /// <summary>
        /// Calls associated Rover's Move method
        /// </summary>
        public void Execute()
        {
            rover.Move();
        }
    }
}
