using System;
using System.Collections.Generic;
using System.Text;

namespace task.Model
{
    class Vehicle
    {
        public string color;
        public string Brand;
        public string Model;
        public int year;
        public int FuelCapacity;
        public int FuelFor1Km;
        public int CurrentFuel;
        public Vehicle()
        {
        }
        public Vehicle(string color)
        {
            this.color = color;
        }
        public Vehicle(string color, string Brand) : this(color)
        {
            this.Brand = Brand;
        }
        public Vehicle(string color, string Brand, string Model) : this(color, Brand)
        {
            this.Model = Model;
        }
        public Vehicle(string color, string Brand, string Model, int year) : this(color, Brand, Model)
        {
            this.year = year;
        }
        public Vehicle(string color, string Brand, string Model, int year, int FuelCapacity) : this(color, Brand, Model, year)
        {
            this.FuelCapacity = FuelCapacity;
        }
        public Vehicle(string color, string Brand, string Model, int year, int FuelCapacity, int FuelFor1Km) : this(color, Brand, Model, year, FuelCapacity)
        {
            this.FuelFor1Km = FuelFor1Km;
        }
        public Vehicle(string color, string Brand, string Model, int year, int FuelCapacity, int FuelFor1Km, int CurrentFuel) : this(color, Brand, Model, year, FuelCapacity, FuelFor1Km)
        {
            this.CurrentFuel = CurrentFuel;
        }
          public void ShowInfo()
        {
            Console.WriteLine($"{color} {Brand} {Model} {year} {FuelCapacity} {FuelFor1Km} {CurrentFuel}");
        }
    }
}
