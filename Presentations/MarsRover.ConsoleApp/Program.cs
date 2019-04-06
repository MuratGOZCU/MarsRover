using System;
using System.Net.Http.Headers;
using MarsRover.Core.Enums;
using MarsRover.Core.Infrastructure;
using MarsRover.Core.Model;

namespace MarsRover.ConsoleApp
{

    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                IVehicle roverManager = new RoverManager(1, 2, Direction.N, new Grid(5, 5));
                Console.WriteLine("Please Forward !");
                var result = roverManager.Process(Console.ReadLine());
                Console.WriteLine(result);
            }

        }

    }
}
