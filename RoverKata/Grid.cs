using System;

namespace RoverKata
{
    public class Grid : IGrid
    {
        public int CoordinateX { get; private set; }
        public int CoordinateY { get; private set; }

        private readonly bool[,] _obstacleDetected;
        private string _obstacleFailureMessage = String.Empty;

        private readonly int _gridSize;

        public Grid(int gridSize, bool[,] obstacleDetected)
        {
            CoordinateX = 0;
            CoordinateX = 0;
            _gridSize = gridSize;
            _obstacleDetected = obstacleDetected;
        }

        public void MoveXForward()
        {
            if (!IsObstacleDetected(CoordinateX, CoordinateY))
            {
                if (CoordinateX < _gridSize)
                {
                    CoordinateX++;
                }
            }

        }

        public void IncreaseForwardPositionY()
        {
            if (!IsObstacleDetected(CoordinateX, CoordinateY))
            {
                if (CoordinateY < _gridSize)
                {
                    CoordinateY++;
                }
            }
        }

        public void IncreaseForwardPositionX()
        {
            if (!IsObstacleDetected(CoordinateX, CoordinateY))
            {
                if (CoordinateX < _gridSize)
                {
                    CoordinateX++;
                }
            }
        }

        public void DecreaseBackwardPositionY()
        {
            if (!IsObstacleDetected(CoordinateX, CoordinateY))
            {
                if (CoordinateY > 0)
                {
                    CoordinateY--;
                }
            }
        }

        public void DecreaseBackwardPositionX()
        {
            if (!IsObstacleDetected(CoordinateX, CoordinateY))
            {
                if (CoordinateX > 0)
                {
                    CoordinateX--;
                }
            }
        }


        public bool IsObstacleDetected(int xcoordinate, int ycoordinate)
        {
            //if (_obstacleDetected[xcoordinate, ycoordinate])
            //{
            //    _obstacleFailureMessage = $"Obstacle detected at {xcoordinate}, {ycoordinate}";
            //}

            for (var index = 0; index < _obstacleDetected.Length; index++)
            {
                if (xcoordinate == index && ycoordinate == index)
                {

                }

            }

            return _obstacleDetected[xcoordinate, ycoordinate];

        }
    }
}