using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverKata
{
    public class Rover
    {
        public int CoordinateX { get; private set; }
        public int CoordinateY { get; private set; }

        public string Direction { get; private set;}

        private readonly int _gridSize;

        public Rover(int gridSize)
        {
            CoordinateX = 0;
            CoordinateY = 0;
            _gridSize = gridSize;


        }



        public void Move(int coordinateX, int coordinateY, string direction, string command)
        {
            if (command == "F" && direction == "N")
            {
                Direction = direction;
                IncreasePositionY();
            }
        }

        private void IncreasePositionY()
        {
            if (CoordinateY < _gridSize)
            {
                CoordinateY++;
            }
        }
    }
}
