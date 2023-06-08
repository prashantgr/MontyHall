using MontyHall.Model;

namespace MontyHall.Interface
{
    public interface IMontyHallSimulator
    {
        SimulationResult SimulateGames(int numSimulations, bool switchDoor);
    }
}