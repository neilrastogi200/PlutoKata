namespace RoverKata.Rover
{
    public interface IRover
    {
        void TurnLeft();

        void TurnRight();

        bool Forward();

        bool Backward();

        string ExecuteCommands(string command);

    }
}