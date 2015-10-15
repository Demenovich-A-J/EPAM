using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheAirline.Interfaces;

namespace TheAirline
{
    class PassengerPlane : IPlane , IPassenger
    {
        public string Name { get; private set; }
        public double Range { get; private set; }
        public double FuelConsumption { get; private set; }
        public int Capacity { get; private set; }

        public PassengerPlane(string name, double range, double fuelConsumption, int capacity)
        {
            Name = name;
            Range = range;
            FuelConsumption = fuelConsumption;
            Capacity = capacity;
        }

        public int CompareTo(IPlane other)
        {
            return this.Range.CompareTo(other.Range);
        }
    }
}
