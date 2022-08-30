using GeveoRover.Enums;

namespace GeveoRover.Helpers
{
    public static class NavigationHelper
    {
        public static void SpinLeft(Rover rover)
        {
            switch (rover.Orientation)
            {
                case Orientation.N:
                    rover.Orientation = Orientation.W;
                    break;
                case Orientation.W:
                    rover.Orientation = Orientation.S;
                    break;
                case Orientation.S:
                    rover.Orientation = Orientation.E;
                    break;
                case Orientation.E:
                    rover.Orientation = Orientation.N;
                    break;
                default:
                    break;
            }
        }

        public static void SpinRight(Rover rover)
        {
            switch (rover.Orientation)
            {
                case Orientation.N:
                    rover.Orientation = Orientation.E;
                    break;
                case Orientation.E:
                    rover.Orientation = Orientation.S;
                    break;
                case Orientation.S:
                    rover.Orientation = Orientation.W;
                    break;
                case Orientation.W:
                    rover.Orientation = Orientation.N;
                    break;
                default:
                    break;
            }
        }

        public static void MoveForward(Rover rover)
        {
            switch (rover.Orientation)
            {
                case Orientation.N:
                    rover.Y += 1;
                    break;
                case Orientation.S:
                    rover.Y -= 1;
                    break;
                case Orientation.E:
                    rover.X += 1;
                    break;
                case Orientation.W:
                    rover.X -= 1;
                    break;
                default:
                    break;
            }
        }
    }
}
