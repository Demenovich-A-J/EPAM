using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAirline
{
    class Passenger : Aircraft
    {
        private int _capacity;

        public Passenger(string name, double range, double fuelConsumption, int capacity) : base(name, range, fuelConsumption)
        {
            Capacity = capacity;
        }

        public Passenger() : base()
        { }
        public int Capacity
        {
            get { return _capacity; }
            set { _capacity = value; }
        }
    }
}
