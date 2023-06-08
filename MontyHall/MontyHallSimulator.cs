using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MontyHall.Interface;
using MontyHall.Model;

namespace MontyHall
{
    // Class to handle the Monty Hall simulation
    public class MontyHallSimulator : IMontyHallSimulator
    {
        public SimulationResult SimulateGames(int numSimulations, bool switchDoor)
        {
            SimulationResult result = new SimulationResult();
            result.TotalGames = numSimulations;

            Random random = new Random();

            for (int i = 0; i < numSimulations; i++)
            {
                int carDoor = random.Next(1, 4); // Randomly assign the car behind one of the three doors
                int chosenDoor = random.Next(1, 4); // Player's initial door choice

                if (!switchDoor)
                {
                    // Player sticks with the initial choice
                    if (chosenDoor == carDoor)
                    {
                        result.Wins++; // Player wins
                    }
                }
                else
                {
                    // Player switches doors
                    if (chosenDoor != carDoor)
                    {
                        result.Wins++; // Player wins
                    }
                }
            }

            return result;
        }
    }

}
