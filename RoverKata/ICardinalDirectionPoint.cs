namespace RoverKata
{
    public interface ICardinalDirectionPoint
    {
        ICardinalDirectionPoint TurnLeft();
        ICardinalDirectionPoint TurnRight();
        void MoveForward();
        void MoveBackward();
    }
}
