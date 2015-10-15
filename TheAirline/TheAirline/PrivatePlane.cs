using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheAirline.Interfaces;

namespace TheAirline
{
    class PrivatePlane : IPlane, IPrivate
    {
        public PrivatePlane(string name, double range, double fuelConsumption, string owner)
        {
            Name = name;
            Range = range;
            FuelConsumption = fuelConsumption;
            Owner = owner;
        }

        public string Name { get; private set; }
        public double Range { get; private set; }
        public double FuelConsumption { get; private set; }
        public string Owner { get; private set; }

        public override string ToString()
        {
            
            return "Name : " + Name
                + "\nRange : " + Range
                + "\nFuel Consumption : " + FuelConsumption
                + "\nOwner : " + Owner + "\n";
        }

        public int CompareTo(IPlane other)
        {
            return this.Range.CompareTo(other.Range);
        }
    }
}
