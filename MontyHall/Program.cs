using MontyHall;
using MontyHall.Model;
using System.Diagnostics.CodeAnalysis;

while (true)
{
    Console.WriteLine("Monty Hall Paradox Simulator");
    Console.WriteLine("-----------------------------");
    Console.WriteLine();

    int numSimulations;
    bool switchDoor;

    // Prompt the user for simulation parameters
    Console.Write("Enter the number of simulations: ");
    while (!int.TryParse(Console.ReadLine(), out numSimulations))
    {
        Console.WriteLine("Invalid input. Please enter a valid integer value.");
        Console.Write("Enter the number of simulations: ");
    }

    Console.Write("Do you want to switch the door? (Y/N): ");
    switchDoor = (Console.ReadLine().ToUpper() == "Y");

    // Perform the simulations
    MontyHallSimulator simulator = new MontyHallSimulator();
    SimulationResult result = simulator.SimulateGames(numSimulations, switchDoor);

    // Display the simulation results
    Console.WriteLine();
    Console.WriteLine("Simulation Results");
    Console.WriteLine("------------------");
    Console.WriteLine($"Total Games: {result.TotalGames}");
    Console.WriteLine($"Wins: {result.Wins}");
    Console.WriteLine($"Win Percentage: {result.WinPercentage}%");

    Console.ReadLine();
}
[ExcludeFromCodeCoverage]
public partial class Program { }