using RoverKata.Grid;

namespace RoverKata.Direction
{
    public class West : ICardinalDirectionPoint
    {
        private readonly IGrid _grid;

        public West(IGrid grid)
        {
            _grid = grid;
        }

        public ICardinalDirectionPoint TurnLeft()
        {
            return new South(_grid);
        }

        public ICardinalDirectionPoint TurnRight()
        {
            return new North(_grid);
        }

        public bool MoveForward()
        {
           return _grid.DecreaseBackwardPositionX();
        }

        public bool MoveBackward()
        {
          return _grid.IncreaseForwardPositionX();
        }

        public override string ToString()
        {
            return "West";
        }
    }
}