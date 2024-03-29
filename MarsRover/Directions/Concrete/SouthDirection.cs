﻿using MarsRover.Directions.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Directions.Concrete
{
    // Güney
    internal class SouthDirection : IRoverState
    {
        public Coordinate _coordinates { get; set; }

        public SouthDirection(Coordinate coordinates)
        {
            _coordinates = coordinates;
        }

        public void MoveForward()
        {
            if (_coordinates.Y > 0)
                _coordinates.Y -= 1;
            else
                Console.WriteLine($"Sınır aşıldı. İleri gidilemiyor!! Min Y : 0");
        }

        public IRoverState TurnLeft()
        {
            return new EastDirection(_coordinates);
        }

        public IRoverState TurnRight()
        {
            return new WestDirection(_coordinates);
        }

        public string GetDirection()
        {
            return "S";
        }
    }
}
