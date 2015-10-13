using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAirline.AirlineBuilder
{
    interface IAircraft
    {
        void BuildName();
        void BuildRange();
        void BuildFuelConsumption();
        void BuildLoadCapacity();
        void BuildCapacity();

        Aircraft GetAircraft();

    }
}
