using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAirline.AirlineBuilder
{
    class Director
    {
        private readonly IAircraftBuilder _objBuilder;
        public Director(IAircraftBuilder builder)
        {
            _objBuilder = builder;
        }

        public void AircraftBuilder()
        {
            _objBuilder.BuildName();
            _objBuilder.BuildRange();
            _objBuilder.BuildFuelConsumption();
            _objBuilder.BuildCapacity();
            _objBuilder.BuildLoadCapacity();
        }

        public Aircraft GetAircraft()
        {
            return _objBuilder.GetAircraft();
        }
    }
}
