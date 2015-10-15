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
        int Сapacity { get; }
        double LoadCapacity { get; }
        List<IPlane> SearchPlane(int from, int to);
        int TotalCapcity();
        double TotalLoadCapcity();
        void Sort();
        void Add(IPlane plane);
        void Remove(IPlane itemPlane);

    }
}
