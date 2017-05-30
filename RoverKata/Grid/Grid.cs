using System.Collections.Generic;

namespace RoverKata.Grid
{
    public class Grid : IGrid
    {
        private readonly int _gridSize;

        public Grid(int gridSize, List<ObstacleDetection.ObstacleDetection> obstacleDetected)
        {
            CoordinateX = 0;
            CoordinateX = 0;
            _gridSize = gridSize;
            ObstacleDetected = obstacleDetected;
        }

        public int CoordinateX { get; private set; }
        public int CoordinateY { get; private set; }

        public List<ObstacleDetection.ObstacleDetection> ObstacleDetected { get; }


        public bool IncreaseForwardPositionY()
        {
            var newYPosition = CoordinateY + 1;

            if (IsObstacleDetected(CoordinateX, newYPosition) == false && newYPosition < _gridSize)
            {
                CoordinateY = newYPosition;
                return false;
            }

            return true;
        }

        public bool IncreaseForwardPositionX()
        {
            var newXPosition = CoordinateX + 1;

            if (IsObstacleDetected(newXPosition, CoordinateY) == false && newXPosition < _gridSize)
            {
                CoordinateX = newXPosition;
                return false;
            }

            return true;
        }

        public bool DecreaseBackwardPositionY()
        {
            var newYPosition = CoordinateY - 1;

            if (IsObstacleDetected(CoordinateX, newYPosition) == false && newYPosition > 0)
            {
                CoordinateY = newYPosition;
                return false;
            }

            return true;
        }

        public bool DecreaseBackwardPositionX()
        {
            var newXPosition = CoordinateX - 1;

            if (IsObstacleDetected(newXPosition, CoordinateY) == false && newXPosition > 0)
            {
                CoordinateX = newXPosition;
                return false;
            }

            return true;
        }


        public bool IsObstacleDetected(int xcoordinate, int ycoordinate)
        {
            foreach (var item in ObstacleDetected)
            {
                if (item.XCoordinate == xcoordinate && item.YCoordinate == ycoordinate)
                {
                    item.Message = $"Rover obstacle encountered [{xcoordinate},{ycoordinate}]";
                    return true;
                }
            }

            return false;
        }
    }
}