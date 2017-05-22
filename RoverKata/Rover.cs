using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoverKata.Direction;

namespace RoverKata
{
    public class Rover
    {
        private readonly IGrid _grid;
    

        public ICardinalDirectionPoint Direction { get; private set; }

        public Rover(IGrid grid)
        {
            _grid = grid;
            Direction = new North(_grid);
        }

        public void TurnLeft()
        {
            Direction = Direction.TurnLeft();
        }

        public void TurnRight()
        {
            Direction = Direction.TurnRight();
        }

        public void Forward()
        {
            Direction.MoveForward();
        }

        public void Backward()
        {
            Direction.MoveBackward();
        }

        public int CoordinateX => _grid.CoordinateX;

        public int CoordinateY => _grid.CoordinateY;

        public override string ToString()
        {
            return $"X : {CoordinateX}, Y : {CoordinateY}, Direction : {Direction}";
        }


        public void ExecuteCommands(string command)
        {
            char[] commands = command.ToCharArray();

            for (int index = 0; index < commands.Length; index++)
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
                    Forward();
                }

                if (comm == 'B')
                {
                    Backward();
                }
            }

        }

    }
}
