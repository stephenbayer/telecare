using Cars;
using Cars.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CarTests
{
    [TestClass]
    public class CarFactoryTest
    {
        private CarFactory _carFactory = new CarFactory();

        [TestMethod]
        public void CanMakeCar()
        {
            ICar car = 
                _carFactory
                    .MakeCar();

            Assert.IsNotNull(car);
        }

        [TestMethod]
        public void CanMakeCarWithPrice()
        {
            double expected = 1000.00;
            CarOptions carOptions = new CarOptions { Price = 1000.00 };
            ICar car = _carFactory.MakeCar(carOptions);

            Assert.AreEqual(expected, car.GetPrice());
        }

        
        [TestMethod]
        public void CanMakeCarWithColor()
        {
            String expected = "Red";
            CarOptions carOptions = new CarOptions { Color = "Red" };
            ICar car = _carFactory.MakeCar(carOptions);

            Assert.AreEqual(expected, car.GetColor());
        }

           
        [TestMethod]
        public void CanMakeCarWithSafetyRating()
        {
            int expected = 3;
            CarOptions carOptions = new CarOptions { SafetyRating = 3 };
            ICar car = _carFactory.MakeCar(carOptions);

            Assert.AreEqual(expected, car.GetSafetyRating());
        }

        
        [TestMethod]
        public void CanMakeCarWithNavigationSystem()
        {
            String expected = "ATMOS";
            CarOptions carOptions = new CarOptions { OtherOptions = new Dictionary<String, Object>() { {"CarNav", "ATMOS" } } };
            ICar car = _carFactory.MakeCar(carOptions);

            Assert.AreEqual(expected, car.GetOption("CarNav"));
        }

        
        [TestMethod]
        public void CanMakeCarWithBluetooth()
        {
            CarOptions carOptions = new CarOptions { OtherOptions = new Dictionary<String, Object>() { {"Bluetooth", true } } };
            ICar car = _carFactory.MakeCar(carOptions);

            Assert.IsTrue((bool)car.GetOption("Bluetooth"));
        }

    }
}
