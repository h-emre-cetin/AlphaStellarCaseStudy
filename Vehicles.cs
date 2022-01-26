using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities;

namespace AlphaStellarCaseStudy
{
    public static class Vehicles
    {
        public static List<Car> CarList = new List<Car>();
        public static List<Bus> BusList = new List<Bus>();
        public static List<Boat> BoatList = new List<Boat>();

        public static void Seed()
        {
            #region CarSeed
            CarList.Add(new Car(1, "red", true, "4", nameof(Car)));
            CarList.Add(new Car(2, "blue", false, "4", nameof(Car)));
            CarList.Add(new Car(3, "green", true, "4", nameof(Car)));
            #endregion

            #region BoatSeed
            BoatList.Add(new Boat(4, "red", nameof(Boat)));
            BoatList.Add(new Boat(5, "blue", nameof(Boat)));
            BoatList.Add(new Boat(6, "green", nameof(Boat)));
            #endregion

            #region BusSeed
            BusList.Add(new Bus(7,"red",nameof(Bus)));
            BusList.Add(new Bus(8,"blue", nameof(Bus)));
            BusList.Add(new Bus(9,"green", nameof(Bus)));
            #endregion
        }
    }
}
