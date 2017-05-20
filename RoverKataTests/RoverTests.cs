using NUnit.Framework;
using RoverKata;

namespace RoverKataTests
{
    [TestFixture]
    public class RoverTests
    {
        [Test]
        public void Given_Position_With_Default_Direction_And_Forward_Command_Returns_0_1_N()
        {
          
            var rover = new Rover(100);

            rover.Move(0, 0, "N", "F");

            Assert.That(rover.CoordinateX, Is.EqualTo(0));
            Assert.That(rover.CoordinateY, Is.EqualTo(1));
            Assert.That(rover.Direction, Is.EqualTo("N"));
            

        }
    }
}
