using System;
using task.Model;

namespace task
{
    class Program
    {
        static void Main(string[] args)
        {
            Car cr1 = new Car("qirmizi", "Nissan", "Juke", 2011, 46, 3, 5);
            Console.WriteLine($"Reng:{cr1.color}, Brend:{cr1.Brand}, Model:{cr1.Model}, il:{cr1.year}, YanacaqTutumu:{cr1.FuelCapacity}, Yanacaq1km:{cr1.FuelFor1Km}, CariYanacaq:{cr1.CurrentFuel}");
            //cr1.ShowInfo();
        }
    }
}
