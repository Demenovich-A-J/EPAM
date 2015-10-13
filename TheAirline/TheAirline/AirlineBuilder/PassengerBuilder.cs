using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAirline.AirlineBuilder
{
    class PassengerBuilder : IAircraft
    {
        private readonly Passenger _passenger = new Passenger();
        public void BuildName()
        {
            _passenger.Name = "";
        }

        public void BuildRange()
        {
            _passenger.Range = new double();
        }

        public void BuildFuelConsumption()
        {
            _passenger.FuelConsumption = new double();
        }

        public void BuildLoadCapacity()
        {
            throw new NotImplementedException();
        }

        public void BuildCapacity()
        {
           _passenger.Capacity = new int();
        }

        public Aircraft GetAircraft()
        {
            return _passenger;
        }
    }
}
