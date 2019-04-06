
using MarsRover.ConsoleApp;
using MarsRover.Core.Enums;
using MarsRover.Core.Infrastructure;
using MarsRover.Core.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsRover.Test
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            IVehicle roverManager = new RoverManagerTest(1, 2, Direction.N, new Grid(5, 5));
            var result = roverManager.Process("LMLMLMLMM");
            Assert.AreEqual("1 3 N", result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            IVehicle roverManager = new RoverManagerTest(3, 3, Direction.E, new Grid(5, 5));
            var result = roverManager.Process("MMRMMRMRRM");
            Assert.AreEqual("5 1 E", result);
        }
    }
}
