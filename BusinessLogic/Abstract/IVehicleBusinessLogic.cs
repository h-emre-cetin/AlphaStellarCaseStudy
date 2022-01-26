using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities;

namespace AlphaStellarCaseStudy.BussinessLogic.Abstract
{
    public interface IVehicleBusinessLogic
    {
        IEnumerable<Vehicle> GetCarsByColor(string color);
        IEnumerable<Vehicle> GetBusesByColor(string color);
        IEnumerable<Vehicle> GetBoatsByColor(string color);
        bool SwitchHeadlights(int id, bool turnOnOff);
        bool DeleteCarById(int id);
    }
}
