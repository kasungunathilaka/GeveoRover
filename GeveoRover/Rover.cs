using GeveoRover.Enums;
using GeveoRover.Helpers;
using System;

namespace GeveoRover
{
    public class Rover : IRover
    {
        private const int minX = 0;
        private const int minY = 0;
        public int X { get; set; }
        public int Y { get; set; }
        public Orientation Orientation { get; set; }

        public Rover()
        {
            X = minX;
            Y = minY;
            Orientation = Orientation.N;
        }

        public void ExploreMinefield(int maxX, int maxY, string instructions)
        {
            foreach (var instruction in instructions)
            {
                switch (instruction)
                {
                    case Constants.SpinLeft:
                        NavigationHelper.SpinLeft(this);
                        break;
                    case Constants.SpinRight:
                        NavigationHelper.SpinRight(this);
                        break;
                    case Constants.MoveForward:
                        NavigationHelper.MoveForward(this);
                        break;
                    default:
                        Console.WriteLine($"Invalid instruction: {instruction}");
                        break;
                }

                if (X < minX || X > maxX || Y < minY || Y > maxY)
                {
                    throw new Exception($"Rover went off the minefield, x: {X}, y: {Y}");
                }
            }
        }
    }
}
