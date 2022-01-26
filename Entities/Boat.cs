using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Boat : Vehicle
    {
        public Boat(int id, string color, string type) : base(id, color, type)
        {
        }
    }
}
