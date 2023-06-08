using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontyHall.Model
{
    // Class to hold the simulation result
    public class SimulationResult
    {
        public int TotalGames { get; set; }
        public int Wins { get; set; }
        public double WinPercentage => (double)Wins / TotalGames * 100;
    }
}
