# Monty Hall Simulator

This project contains a Monty Hall simulator implemented in C#. The Monty Hall problem is a probability puzzle that involves three doors, behind which there is a valuable prize (e.g., a car) and two worthless items (e.g., goats). The player initially chooses a door, and then the host, who knows what's behind each door, reveals one of the remaining doors that contains a worthless item. The player is then given the option to stick with their initial choice or switch to the other unopened door. The simulation runs multiple games and tracks the outcomes based on whether the player switches doors or sticks with their initial choice.

## Installation

To run the Monty Hall simulator, follow these steps:

1. Clone the repository or download the source code.
2. Open the project in Visual Studio or your preferred C# development environment.
3. Build the solution to restore the dependencies and compile the code.
4. Run the application.

## Usage

The `MontyHallSimulator` class provides a method `SimulateGames` that accepts two parameters:

- `numSimulations`: The number of simulations or games to run.
- `switchDoor`: A boolean indicating whether the player should switch doors after the host reveals a goat.

```csharp
public SimulationResult SimulateGames(int numSimulations, bool switchDoor)
