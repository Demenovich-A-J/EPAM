using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAirline
{
    class Transport : Aircraft
    {
        private double _loadCapacity;
        public Transport(string name, double range, double fuelConsumption, double loadCapacity) : base(name, range, fuelConsumption)
        {
            LoadCapacity = loadCapacity;
        }

        public double LoadCapacity
        {
            get { return _loadCapacity; }
            set { _loadCapacity = value; }
        }
    }
}
