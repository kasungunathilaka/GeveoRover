using GeveoRover.Enums;
using System;

namespace GeveoRover
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geveo Rovers");
            try
            {
                Console.WriteLine("Enter upper-right coordinates of the mindfield.");
                var maxCoordinates = Console.ReadLine().Trim().Split(' ');
                if (maxCoordinates.Length != 2 || int.Parse(maxCoordinates[0]) <= 0 || int.Parse(maxCoordinates[1]) <= 0)
                {
                    throw new Exception($"Invalid upper-right coordinations");
                }

                Console.WriteLine("Enter initial coordinates of the rover with orientation.");
                var initialCoordinates = Console.ReadLine().Trim().ToUpper().Split(' ');
                if (initialCoordinates.Length != 3 ||
                    int.Parse(initialCoordinates[0]) < 0 || int.Parse(initialCoordinates[0]) > int.Parse(maxCoordinates[0]) ||
                    int.Parse(initialCoordinates[1]) < 0 || int.Parse(initialCoordinates[1]) > int.Parse(maxCoordinates[1]))
                {
                    throw new Exception($"Invalid initial coordinations");
                }

                Console.WriteLine("Enter rover instructions.");
                var instructions = Console.ReadLine().ToUpper();
                if (string.IsNullOrWhiteSpace(instructions))
                {
                    throw new Exception($"Invalid instructions");
                }

                Rover rover = new Rover
                {
                    X = int.Parse(initialCoordinates[0]),
                    Y = int.Parse(initialCoordinates[1]),
                    Orientation = (Orientation)Enum.Parse(typeof(Orientation), initialCoordinates[2])
                };

                rover.ExploreMinefield(int.Parse(maxCoordinates[0]), int.Parse(maxCoordinates[1]), instructions);
                Console.WriteLine($"Final coordinations of rover, x: {rover.X}, y: {rover.Y}, orientation: {rover.Orientation}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occurred: {ex.Message}");
            }
            Console.ReadLine();
        }
    }
}
