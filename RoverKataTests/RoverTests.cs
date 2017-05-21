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

            rover.Move(0, 0, 'N', "F");

            Assert.That(rover.CoordinateX, Is.EqualTo(0));
            Assert.That(rover.CoordinateY, Is.EqualTo(1));
            Assert.That(rover.Direction, Is.EqualTo('N'));
            
        }

        [Test]
        public void When_Rover_Is_Created_And_Command_Is_Turn_Right_Expected_Direction_Is_East()
        {
            var rover = new Rover(100);

            rover.Move(0, 0, 'N', "R");

            Assert.That(rover.CoordinateX, Is.EqualTo(0));
            Assert.That(rover.CoordinateY, Is.EqualTo(0));
            Assert.That(rover.Direction, Is.EqualTo('E'));


        }

        [Test]
        public void When_Rover_Is_Created_And_Command_Is_Turn_Left_Expected_Direction_Is_West()
        {
            var rover = new Rover(100);

            rover.Move(0, 0, 'N', "L");

            Assert.That(rover.CoordinateX, Is.EqualTo(0));
            Assert.That(rover.CoordinateY, Is.EqualTo(0));
            Assert.That(rover.Direction, Is.EqualTo('W'));


        }

        [Test]
        public void When_Rover_Is_Created_And_Command_Is_Forward_And_Direction_Is_South()
        {
            var rover = new Rover(100);

            rover.Move(0, 1, 'S', "F");

            Assert.That(rover.CoordinateX, Is.EqualTo(0));
            Assert.That(rover.CoordinateY, Is.EqualTo(0));
            Assert.That(rover.Direction, Is.EqualTo('S'));
        }



    }
}
