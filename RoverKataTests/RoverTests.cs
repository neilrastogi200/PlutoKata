using System.Collections.Generic;
using NUnit.Framework;
using RoverKata.Direction;
using RoverKata.Grid;
using RoverKata.ObstacleDetection;
using RoverKata.Rover;

namespace RoverKataTests
{
    [TestFixture]
    public class RoverTests
    {
        [SetUp]
        public void Setup()
        {
            var obstacleDetections = new List<ObstacleDetection>
            {
                new ObstacleDetection {XCoordinate = 3, YCoordinate = 3}
            };

            _grid = new Grid(100, obstacleDetections);
        }

        private IGrid _grid;


        [Test]
        [TestCase("RFLFFRF", 2, 2, "East")]
        [TestCase("RFLLF", 1, 0, "West")]
        [TestCase("RFFBLB", 1, 0, "North")]
        public void ExecuteCommands_With_Multiple_Commands(string commandString, int xCoordinateExpected,
            int yCoordinateExpected, string directionExpected)
        {
            //Arrange
            var rover = new Rover(_grid);
            //Act
            rover.ExecuteCommands(commandString);

            //Assert
            Assert.That(rover.CoordinateX, Is.EqualTo(xCoordinateExpected));
            Assert.That(rover.CoordinateY, Is.EqualTo(yCoordinateExpected));
            Assert.That(rover.Direction.ToString(), Is.EqualTo(directionExpected));
        }


        [Test]
        public void Given_Position_With_Default_Direction_And_Forward_Command_Returns_0_1_N()
        {
            //Arrange
            var rover = new Rover(_grid);

            //Act
            rover.ExecuteCommands("F");

            //Assert
            Assert.That(rover.CoordinateX, Is.EqualTo(0));
            Assert.That(rover.CoordinateY, Is.EqualTo(1));
            Assert.That(rover.Direction, Is.TypeOf(typeof (North)));
        }

        [Test]
        public void When_Rover_Command_Is_Backwards_And_The_Direction_Is_South_With_Default_Coordinates()
        {
            //Arrange
            var rover = new Rover(_grid);

            var command = "B";
            //Act
            rover.ExecuteCommands(command);
            //Assert
            Assert.That(rover.Direction, Is.TypeOf<North>());
            Assert.That(rover.CoordinateX, Is.EqualTo(0));
            Assert.That(rover.CoordinateY, Is.EqualTo(0));
        }


        [Test]
        public void When_Rover_Command_Is_Executed_Obstacle_Encountered()
        {
            //Arrange
            var obstacleDetections = new List<ObstacleDetection>
            {
                new ObstacleDetection {XCoordinate = 4, YCoordinate = 5}
            };

            _grid = new Grid(100, obstacleDetections);
            var rover = new Rover(_grid);

            var expectedMessage = "Rover obstacle encountered [4,5]";

            var command = "FFFFFRFFFFF";
            //Act
            rover.ExecuteCommands(command);

            //Assert
            Assert.AreEqual(rover.CoordinateX, 3);
            Assert.AreEqual(rover.CoordinateY, 5);
            Assert.AreEqual(_grid.ObstacleDetected[0].Message, expectedMessage);
        }


        [Test]
        public void When_Rover_Command_Is_Forward_And_TurnRight_The_Direction_Is_East()
        {
            //Arrange
            var rover = new Rover(_grid);

            var command = "FR";
            //Act
            rover.ExecuteCommands(command);
            //Assert
            Assert.That(rover.Direction, Is.TypeOf<East>());
            Assert.That(rover.CoordinateX, Is.EqualTo(0));
            Assert.That(rover.CoordinateY, Is.EqualTo(1));
        }


        [Test]
        public void When_Rover_Command_Is_Left_And_The_Direction_Is_West_With_Default_Coordinates()
        {
            //Arrange
            var rover = new Rover(_grid);

            var command = "L";

            //Act
            rover.ExecuteCommands(command);
            //Assert
            Assert.That(rover.Direction, Is.TypeOf<West>());
            Assert.That(rover.CoordinateX, Is.EqualTo(0));
            Assert.That(rover.CoordinateY, Is.EqualTo(0));
        }


        [Test]
        public void When_Rover_Command_Is_Right_And_The_Direction_Is_East_With_Default_Coordinates()
        {
            //Arrange
            var rover = new Rover(_grid);
            var command = "R";
            //Act
            rover.ExecuteCommands(command);
            //Assert
            Assert.That(rover.Direction, Is.TypeOf<East>());
            Assert.That(rover.CoordinateX, Is.EqualTo(0));
            Assert.That(rover.CoordinateY, Is.EqualTo(0));
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
    }
}