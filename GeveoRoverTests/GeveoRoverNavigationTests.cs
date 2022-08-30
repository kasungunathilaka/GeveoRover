using GeveoRover;
using GeveoRover.Enums;
using System;
using Xunit;

namespace GeveoRoverTests
{
    public class GeveoRoverNavigationTests
    {
        [Fact]
        public void TestScenario1_12N_LMLMLMLMM_Returns_13N()
        {
            int maxX = 5;
            int maxY = 5;
            string instructions = "LMLMLMLMM";

            Rover rover = new Rover
            {
                X = 1,
                Y = 2,
                Orientation = Orientation.N
            };

            rover.ExploreMinefield(maxX, maxY, instructions);

            Assert.Equal(1, rover.X);
            Assert.Equal(3, rover.Y);
            Assert.Equal(Orientation.N, rover.Orientation);
        }

        [Fact]
        public void TestScenario2_33E_MMRMMRMRRM_Returns_51E()
        {
            int maxX = 5;
            int maxY = 5;
            string instructions = "MMRMMRMRRM";

            Rover rover = new Rover
            {
                X = 3,
                Y = 3,
                Orientation = Orientation.E
            };

            rover.ExploreMinefield(maxX, maxY, instructions);

            Assert.Equal(5, rover.X);
            Assert.Equal(1, rover.Y);
            Assert.Equal(Orientation.E, rover.Orientation);
        }
    }
}
