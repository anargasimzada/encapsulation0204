﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationCar.Models
{
    internal class ElectricCar:Cars
    {
        private int _battery = 100;
        public int Battery
        {
            get => _battery;
            protected set
            {
                if (value < 0)
                {
                    Console.WriteLine("Battery empty");
                    _battery = 0;
                }
                else
                {
                    _battery = value;
                }
            }
        }
    }
}
