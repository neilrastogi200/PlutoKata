using RoverKata.Grid;

namespace RoverKata.Direction
{
    public class East : ICardinalDirectionPoint
    {
        private readonly IGrid _grid;

        public East(IGrid grid)
        {
            _grid = grid;
        }

        public ICardinalDirectionPoint TurnLeft()
        {
            return new North(_grid);
        }

        public ICardinalDirectionPoint TurnRight()
        {
            return new South(_grid);
        }

        public bool MoveForward()
        {
            return _grid.IncreaseForwardPositionX();
        }

        public bool MoveBackward()
        {
           return _grid.DecreaseBackwardPositionX();
        }

        public override string ToString()
        {
            return "East";
        }
    }
}