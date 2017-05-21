namespace RoverKata
{
    public interface IGrid
    {
        int CoordinateX { get; }
        int CoordinateY { get; }
        void IncreaseForwardPositionY();
        void IncreaseForwardPositionX();
        void DecreaseBackwardPositionY();
        void DecreaseBackwardPositionX();
    }
}
