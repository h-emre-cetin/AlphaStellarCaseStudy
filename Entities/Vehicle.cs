using System;

namespace Entities
{
    public abstract class Vehicle
    {
        public int Id { get; set; }
        public string Color { get; set; }
        public string VehicleType { get; set; }
        public Vehicle(int id, string color,string vehicleType)
        {
            Id = id;
            Color = color;
            VehicleType = vehicleType;
        }
    }
}
