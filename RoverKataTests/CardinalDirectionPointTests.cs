using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using RoverKata;
using RoverKata.Direction;
using RoverKata.Grid;
using RoverKata.ObstacleDetection;

namespace RoverKataTests
{
    [TestFixture]
    public class CardinalDirectionPointTests
    {
        private IGrid _grid;

        [SetUp]
        public void Setup()
        {
            List<ObstacleDetection> obstacleDetections = new List<ObstacleDetection>() {new ObstacleDetection() {XCoordinate = 2, YCoordinate = 1} };
                
                
                
                _grid = new Grid(100, obstacleDetections );
        }

        [Test]
        public void When_Command_Is_Turn_Right_Expected_Direction_Is_East()
        {
            //Arrange
            var directionPoint = new North(_grid);

            //Act
           var actualResult = directionPoint.TurnRight();

            //Assert
            Assert.That(actualResult,Is.TypeOf(typeof(East)));
        
        }

        [Test]
        public void When_Command_Is_Turn_Left_Expected_Direction_Is_West()
        {
            //Arrange
            var directionPoint = new North(_grid);

            //Act
            var actualResult = directionPoint.TurnLeft();

            //Assert
            Assert.That(actualResult, Is.TypeOf(typeof(West)));
        }


        [Test]
        public void When_Direction_Is_East_And_Turn_Left_Direction_Should_Be_North()
        {
            //Arrange
            var directionPoint = new East(_grid);

            //Act
            var actualResult = directionPoint.TurnLeft();

            //Assert
            Assert.That(actualResult, Is.TypeOf<North>());
        }

        [Test]
        public void When_Direction_Is_East_And_Turn_Right_Direction_Should_Be_South()
        {
            //Arrange
            var directionPoint = new East(_grid);

            //Act
            var actualResult = directionPoint.TurnRight();

            //Assert
            Assert.That(actualResult, Is.TypeOf<South>());

        }

        [Test]
        public void When_Direction_Is_South_And_Turn_Left_Direction_Should_Be_East()
        {
            //Arrange
            var directionPoint = new South(_grid);

            //Act
            var actualResult = directionPoint.TurnLeft();

            //Assert
            Assert.That(actualResult, Is.TypeOf<East>());
        }

        [Test]
        public void When_South_And_Turn_Right_Direction_Should_Be_West()
        {
            //Arrange
            var directionPoint = new South(_grid);

            //Act
            var actualResult = directionPoint.TurnRight();

            //Assert
            Assert.That(actualResult, Is.TypeOf<West>());
        }

    }
}
