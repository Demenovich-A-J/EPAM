using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAirline
{
    class Passenger : Aircraft
    {
        private readonly int _capacity;

        public Passenger(string name, double range, double fuelConsumption, int capacity) : base(name, range, fuelConsumption)
        {
            _capacity = capacity;
        }

        public int Capacity
        {
            get { return _capacity; }
        }
    }
}
