using MarsRover.Library.Model;
using MarsRover.Library.Model.Command;
using MarsRover.Library.Strategy;
using System;
using System.Collections.Generic;

namespace MarsRover
{
    class Program
    {
        static int PLATEAU_LOWER_BOUNDRY_BORDER_X = 0;
        static int PLATEAU_LOWER_BOUNDRY_BORDER_Y = 0;
        static int PLATEAU_UPPER_BOUNDRY_BORDER_X = 0;
        static int PLATEAU_UPPER_BOUNDRY_BORDER_Y = 0;
        static Dictionary<Rover, string> cases = new Dictionary<Rover, string>();
        /// <summary>
        /// With this solution implementation of the given case study, Rovers created with given Directions. Command sequences turn into Command objects and Commands executed with CommandExecutor. Border strategies implemented. If any rover tries to move out of the plateau border, depending on the chosen strategy an Exception could be thrown or the Rover could wait at the border.
        /// Singleton, Strategy, Command and Factory Method Design Patterns are implemented.
        /// </summary>
        static void Main(string[] args)
        {
            SetupData();
            
            foreach (var singleCase in cases)
            {
                // Execute commands for each case
                CommandExecutor.ExecuteCommands(singleCase.Key, singleCase.Value);
                
                // Write case results for each case
                Console.WriteLine("{0} {1} {2}", singleCase.Key.currentCoordinates.coordX, singleCase.Key.currentCoordinates.coordY, singleCase.Key.GetDirection());
            }
        }
        /// <summary>
        /// Read data from console until entered line is empty. Setup test cases.
        /// </summary>
        static void SetupData()
        {
            // Setup Plateau Borders
            string plateauBorders = Console.ReadLine();
            PLATEAU_UPPER_BOUNDRY_BORDER_X = int.Parse(plateauBorders.Split(' ')[0]);
            PLATEAU_UPPER_BOUNDRY_BORDER_Y = int.Parse(plateauBorders.Split(' ')[1]);

            // Create movement strategy for rovers
            BorderStrategy borderStrategy = new ThrowExceptionBorderStrategy(PLATEAU_LOWER_BOUNDRY_BORDER_X, PLATEAU_LOWER_BOUNDRY_BORDER_Y, PLATEAU_UPPER_BOUNDRY_BORDER_X, PLATEAU_UPPER_BOUNDRY_BORDER_Y);

            while(true)
            {
                string roverInfo = Console.ReadLine();

                if (string.IsNullOrEmpty(roverInfo))
                    break;

                // Create new rover and set movement strategy
                Rover rover = Rover.GetNewRover(int.Parse(roverInfo.Split(' ')[0]), int.Parse(roverInfo.Split(' ')[1]), roverInfo.Split(' ')[2].ToCharArray()[0], borderStrategy);
                string commandSequence = Console.ReadLine();

                // Create case. Assign command sequence to rover
                cases.Add(rover, commandSequence);
            }
        }
    }
}
