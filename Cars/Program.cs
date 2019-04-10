using Cars.Models;
using System;

namespace Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            CarFactory carFactory = new CarFactory();

            ICar car = carFactory.MakeCar(new CarOptions()
            {
                Color = "Red",
                Price = 1000000,
                SafetyRating = 5,
                OtherOptions = new System.Collections.Generic.Dictionary<string, object>()
                {
                    { "NavSystem", "ATMOS" },
                    { "Bluetooth", false }
                }
            });
            Console.WriteLine("Car Made");
            Console.WriteLine(car.ToString());
            Console.ReadKey();
        }
    }
}
