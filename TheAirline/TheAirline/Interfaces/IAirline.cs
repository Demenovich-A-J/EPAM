using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAirline.Interfaces
{
    interface IAirline
    {
        string AirlineName { get; }
        List<IPlane> Planes { get; }
        int TotalCapcity();
        void Sort();
        void Add(IPlane plane);
        void Remove(int index);

    }
}
