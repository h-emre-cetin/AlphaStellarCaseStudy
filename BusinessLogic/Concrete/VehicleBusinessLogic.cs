using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlphaStellarCaseStudy.BussinessLogic.Abstract;
using Entities;

namespace AlphaStellarCaseStudy.BusinessLogic.Concrete
{
    public class VehicleBusinessLogic : IVehicleBusinessLogic
    {
        public IEnumerable<Vehicle> GetCarsByColor(string color)
        {
            var carList = Vehicles.CarList.Where(p => p.VehicleType == nameof(Car) && p.Color == color);
            return carList;
        }

        public IEnumerable<Vehicle> GetBusesByColor(string color)
        {
            var busList = Vehicles.BusList.Where(p => p.VehicleType == nameof(Bus) && p.Color == color);
            return busList;
        }

        public IEnumerable<Vehicle> GetBoatsByColor(string color)
        {
            var boatList = Vehicles.BoatList.Where(p => p.VehicleType == nameof(Boat) && p.Color == color);
            return boatList;
        }

        public bool SwitchHeadlights(int id, bool turnOnOff)
        {
            var car = Vehicles.CarList.Where(p => p.Id == id);
            if (car is Car c)
            {
                c.Headlights = turnOnOff;
                return true;
            }
            return false;
        }

        public bool DeleteCarById(int id)
        {
            var car = Vehicles.CarList.SingleOrDefault(p => p.Id == id);
            if (car != null)
            {
                Vehicles.CarList.Remove(car);
                return true;
            }
            return false;
        }
    }
}
