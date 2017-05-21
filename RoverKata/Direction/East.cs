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

        public void MoveForward()
        {
            _grid.IncreaseForwardPositionX();
        }

        public void MoveBackward()
        {
            _grid.DecreaseBackwardPositionX();
        }

        public override string ToString()
        {
            return "East";
        }
    }
}