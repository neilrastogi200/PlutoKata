namespace RoverKata
{
    public class Grid : IGrid
    {
        public int CoordinateX { get; private set; }
        public int CoordinateY { get; private set; }

        private readonly int _gridSize;

        public Grid(int gridSize)
        {
            CoordinateX = 0;
            CoordinateX = 0;
            _gridSize = gridSize;
        }

        public void MoveXForward()
        {
            if (CoordinateX < _gridSize)
            {
                CoordinateX++;
            }
        }

        public void IncreaseForwardPositionY()
        {
            if (CoordinateY < _gridSize)
            {
                CoordinateY++;
            }
        }

        public void IncreaseForwardPositionX()
        {
            if (CoordinateX < _gridSize)
            {
                CoordinateX++;
            }
        }

        public void DecreaseBackwardPositionY()
        {
            if (CoordinateY > 0)
            {
                CoordinateY--;
            }
        }

        public void DecreaseBackwardPositionX()
        {
            if (CoordinateX > 0)
            {
                CoordinateX--;
            }
        }
    }
}