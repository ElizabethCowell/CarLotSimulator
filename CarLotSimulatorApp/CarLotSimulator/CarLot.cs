﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    public class CarLot
    {
        public CarLot()
        {
        }
        public List<Car> Cars { get; set; } = new List<Car>();
        public static int NumberOfCars { get; set; }
    }

}
