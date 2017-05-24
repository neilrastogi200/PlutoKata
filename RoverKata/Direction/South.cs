using RoverKata.Grid;

namespace RoverKata.Direction
{
    public class South : ICardinalDirectionPoint
    {
        private readonly IGrid _grid;

        public South(IGrid grid)
        {
            _grid = grid;
        }

        public ICardinalDirectionPoint TurnLeft()
        {
            return new East(_grid);
        }

        public ICardinalDirectionPoint TurnRight()
        {
            return new West(_grid);
        }

        public bool MoveForward()
        {
           return _grid.DecreaseBackwardPositionY();
        }

        public bool MoveBackward()
        {
          return _grid.IncreaseForwardPositionY();
        }

        public override string ToString()
        {
            return "South";
        }
    }
}