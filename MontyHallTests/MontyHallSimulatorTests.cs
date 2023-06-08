using NUnit.Framework;
using MontyHall;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MontyHall.Model;

namespace MontyHall.Tests
{
    [TestFixture()]
    public class MontyHallSimulatorTests
    {
        [Test]
        public void SimulateGames_ShouldReturnValidSimulationResult()
        {
            // Arrange
            int numSimulations = 1000;
            bool switchDoor = true;

            // Act
            MontyHallSimulator simulator = new MontyHallSimulator();
            SimulationResult result = simulator.SimulateGames(numSimulations, switchDoor);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(numSimulations, result.TotalGames);
            Assert.GreaterOrEqual(result.Wins, 0);
            Assert.LessOrEqual(result.Wins, numSimulations);
            Assert.GreaterOrEqual(result.WinPercentage, 0);
            Assert.LessOrEqual(result.WinPercentage, 100);
        }
        [Test]
        public void SimulateGames_SwitchDoor_WinPercentageApproximately66()
        {
            // Arrange
            MontyHallSimulator simulator = new MontyHallSimulator();
            int numSimulations = 10000;
            bool switchDoor = true;

            // Act
            SimulationResult result = simulator.SimulateGames(numSimulations, switchDoor);

            // Assert
            Assert.That(result.WinPercentage, Is.EqualTo(66).Within(2));
        }

        [Test]
        public void SimulateGames_NotSwitchDoor_WinPercentageApproximately33()
        {
            // Arrange
            MontyHallSimulator simulator = new MontyHallSimulator();
            int numSimulations = 10000;
            bool switchDoor = false;

            // Act
            SimulationResult result = simulator.SimulateGames(numSimulations, switchDoor);

            // Assert
            Assert.That(result.WinPercentage, Is.EqualTo(33).Within(2));
        }
    }

}
