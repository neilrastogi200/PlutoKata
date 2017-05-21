using NUnit.Framework;
using RoverKata;
using RoverKata.Direction;

namespace RoverKataTests
{
    [TestFixture]
    public class RoverTests
    {
        private IGrid _grid;

        [SetUp]
        public void Setup()
        {
            _grid = new Grid(100);
        }


        [Test]
        public void Given_Position_With_Default_Direction_And_Forward_Command_Returns_0_1_N()
        {
            //Arrange
            var rover = new Rover(_grid);

            //Act
            rover.Forward();

            //Assert
            Assert.That(rover.CoordinateX, Is.EqualTo(0));
            Assert.That(rover.CoordinateY, Is.EqualTo(1));
            Assert.That(rover.Direction, Is.TypeOf(typeof(North)));

        }

        [Test]
        public void When_Rover_Is_Created_And_Turn_Left_The_Direction_Is_West()
        {
            //Arrange
            var rover = new Rover(_grid);
            //Act
            rover.TurnLeft();
            //Assert
            Assert.That(rover.Direction, Is.TypeOf<West>());
        }


        [Test]
        public void When_Rover_Is_Created_And_Turn_Right_The_Direction_Is_East()
        {
            //Arrange
            var rover = new Rover(_grid);
            //Act
            rover.TurnRight();
            //Assert
            Assert.That(rover.Direction, Is.TypeOf<East>());
        }


        [Test]
        public void When_Rover_Command_Is_Right_And_The_Direction_Is_East()
        {
            //Arrange
            var rover = new Rover(_grid);
            var command = "R";
            //Act
            rover.ExecuteCommands(command);
         
        }


        [Test]
        public void When_Rover_Command_Is_Left_And_The_Direction_Is_East()
        {
            //Arrange
            var rover = new Rover(_grid);
            var command = "L";
            //Act
            rover.ExecuteCommands(command);

        }

        [Test]
        public void When_Rover_Command_Is_Backwards_And_The_Direction_Is_East()
        {
            //Arrange
            var rover = new Rover(_grid);
            var command = "B";
            //Act
            rover.ExecuteCommands(command);

        }

        [Test]
        public void When_Rover_Command_Is_Forward_And_The_Direction_Is_East()
        {
            //Arrange
            var rover = new Rover(_grid);
            var command = "B";
            //Act
            rover.ExecuteCommands(command);

        }



    }
}
