using RoverKata.Direction;
using RoverKata.Grid;

namespace RoverKata.Rover
{
    public class Rover : IRover
    {
        private readonly IGrid _grid;

        public Rover(IGrid grid)
        {
            _grid = grid;
            Direction = new North(_grid);
        }


        public ICardinalDirectionPoint Direction { get; private set; }

        public int CoordinateX => _grid.CoordinateX;

        public int CoordinateY => _grid.CoordinateY;

        public void TurnLeft()
        {
            Direction = Direction.TurnLeft();
        }

        public void TurnRight()
        {
            Direction = Direction.TurnRight();
        }

        public bool Forward()
        {
            return Direction.MoveForward();
        }

        public bool Backward()
        {
            return Direction.MoveBackward();
        }

        public override string ToString()
        {
            return $"X : {CoordinateX}, Y : {CoordinateY}, Direction : {Direction}";
        }


        public string ExecuteCommands(string command)
        {
            var commands = command.ToCharArray();

            for (var index = 0; index < commands.Length; index++)
            {
                var comm = commands[index];
                if (comm == 'L')
                {
                    TurnLeft();
                }

                if (comm == 'R')
                {
                    TurnRight();
                }

                if (comm == 'F')
                {
                    if (Forward())
                    {
                        foreach (var item in _grid.ObstacleDetected)
                        {
                            if (!string.IsNullOrEmpty(item.Message))
                            {
                                return item.Message;
                            }
                            break;
                        }
                    }
                }

                if (comm == 'B')
                {
                    if (Backward())
                    {
                        foreach (var item in _grid.ObstacleDetected)
                        {
                            if (!string.IsNullOrEmpty(item.Message))
                            {
                                return item.Message;
                            }

                            break;
                        }
                    }
                }
            }

            return null;
        }
    }
}