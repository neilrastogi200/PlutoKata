namespace RoverKata.Direction
{
    public class North : ICardinalDirectionPoint
    {
        private readonly IGrid _grid;

        public North(IGrid grid)
        {
            _grid = grid;
        }

        public ICardinalDirectionPoint TurnLeft()
        {
            return new West(_grid);
        }

        public ICardinalDirectionPoint TurnRight()
        {
            return new East(_grid);
        }

        public void MoveForward()
        {
            _grid.IncreaseForwardPositionY();
        }

        public void MoveBackward()
        {
            _grid.DecreaseBackwardPositionY();
        }

        public override string ToString()
        {
            return "North";
        }
    }
}
