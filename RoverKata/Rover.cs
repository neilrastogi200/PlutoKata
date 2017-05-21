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

        public char Direction { get; private set;}

        private readonly int _gridSize;

        public Rover(int gridSize)
        {
            CoordinateX = 0;
            CoordinateY = 0;
            _gridSize = gridSize;


        }



        public void Move(int coordinateX, int coordinateY, char direction, string command)
        {
           var resultNorth = Enum.GetName(typeof (DirectionEnum), DirectionEnum.N);
            var resultSouth = Enum.GetName(typeof (DirectionEnum), DirectionEnum.S);

            if (resultNorth != null && (command == "F" && direction == Convert.ToChar(resultNorth)))
            {
                Direction = direction;
                IncreasePositionY();
            }

            if (resultSouth != null && (command == "F" && direction == Convert.ToChar(resultSouth)))
            {
                Direction = direction;
                CoordinateY = coordinateY;
                DecreasePositionY();
            }

            if (command == "L" || command == "R")
            {
                Direction = direction;
                Turn(Convert.ToChar(command));
            }
        }

        private void IncreasePositionY()
        {
            if (CoordinateY < _gridSize)
            {
                CoordinateY++;
            }
        }


        private void DecreasePositionY()
        {
            if (CoordinateY > 0)
            {
                CoordinateY--;
            }
        }


        private void Turn(char command)
        {

            var resultNorth = Enum.GetName(typeof(DirectionEnum), DirectionEnum.N);
            var resultSouth = Enum.GetName(typeof(DirectionEnum), DirectionEnum.S);
            var resultEast = Enum.GetName(typeof(DirectionEnum), DirectionEnum.E);
            var resultWest = Enum.GetName(typeof(DirectionEnum), DirectionEnum.W);

            if (command == 'L')
            {
                switch (Direction)
                {
                    case 'N':
                        if (resultWest != null) Direction = Convert.ToChar(resultWest);
                        break;
                    case 'W':
                        if (resultSouth != null) Direction = Convert.ToChar(resultSouth);
                        break;
                    case 'S':
                        if (resultWest != null) Direction = Convert.ToChar(resultWest);
                        break;
                    default:
                        break;
                }
            }
            else if (command == 'R')
            {
                switch (Direction)
                {
                    case 'N':
                        if (resultEast != null) Direction = Convert.ToChar(resultEast);
                        break;
                    case 'E':
                        if (resultSouth != null) Direction = Convert.ToChar(resultSouth);
                        break;
                    case 'S':
                        if (resultEast != null) Direction = Convert.ToChar(resultEast);
                        break;
                    default:
                        break;
                }
            }


        }
    }
    }
