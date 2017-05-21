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

        public void MoveForward()
        {
            _grid.DecreaseBackwardPositionX();
        }

        public void MoveBackward()
        {
           _grid.IncreaseForwardPositionX();
        }

        public override string ToString()
        {
            return "West";
        }
    }
}