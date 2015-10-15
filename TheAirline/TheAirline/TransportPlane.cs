using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheAirline.Interfaces;

namespace TheAirline
{
    class TransportPlane : IPlane, ITransport
    {
        public TransportPlane(string name, double range, double fuelConsumption, double loadCapacity)
        {
            Name = name;
            Range = range;
            FuelConsumption = fuelConsumption;
            LoadCapacity = loadCapacity;
        }

        public string Name { get; private set; }
        public double Range { get; private set; }
        public double FuelConsumption { get; private set; }
        public double LoadCapacity { get; private set; }

        public override string ToString()
        {
            return "Name : " + Name
                + "\nRange : " + Range
                + "\nFuel Consumption : " + FuelConsumption
                + "\nLoad Capacity : " + LoadCapacity + "\n";
        }

        public int CompareTo(IPlane other)
        {
            return this.Range.CompareTo(other.Range);
        }
    }
}
