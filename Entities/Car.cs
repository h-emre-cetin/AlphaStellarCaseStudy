using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Car : Vehicle
    {
        public Car(int id,string color, bool headlights, string wheels, string type) : base(id,color, type)
        {
            Headlights = headlights;
            Wheels = wheels;
        }

        public bool Headlights { get; set; }
        public string Wheels { get; set; }
    }
}
