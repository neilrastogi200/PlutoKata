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

        public void MoveForward()
        {
            _grid.DecreaseBackwardPositionY();
        }

        public void MoveBackward()
        {
            _grid.IncreaseForwardPositionY();
        }

        public override string ToString()
        {
            return "South";
        }
    }
}