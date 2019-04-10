using System;
using System.Collections.Generic;
using System.Text;
using Cars.Models;

namespace Cars
{
    public class CarFactory
    {
        public ICar MakeCar(CarOptions carOptions = null)
        {
            Car car = new Car();
            car.SetPrice(carOptions?.Price == null ? 0 : carOptions.Price);
            car.SetColor(String.IsNullOrEmpty(carOptions?.Color) ? "N/A" : carOptions.Color);
            car.SetSafetyRating(carOptions?.SafetyRating == null ? 0 : carOptions.SafetyRating);
            car.SetOptions(carOptions?.OtherOptions);
            
            return car;
        }
    }
}
