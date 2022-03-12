using System;
using System.Collections.Generic;
using System.Text;

namespace task.Model
{
    class Car : Vehicle
    {
        public Car()
        {
        }
        public Car(string color, string Brand, string Model, int year, int FuelCapacity, int FuelFor1Km, int CurrentFuel) : base(color, Brand, Model, year, FuelCapacity, FuelFor1Km, CurrentFuel)
        {

        }
    }
}

 