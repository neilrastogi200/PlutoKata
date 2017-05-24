namespace RoverKata.Direction
{
    public interface ICardinalDirectionPoint
    {
        ICardinalDirectionPoint TurnLeft();
        ICardinalDirectionPoint TurnRight();
        bool MoveForward();
        bool MoveBackward();
    }
}
