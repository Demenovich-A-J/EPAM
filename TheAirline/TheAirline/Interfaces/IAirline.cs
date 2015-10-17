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
        IList<IPlane> Planes { get; }
        int Сapacity { get; }
        double LoadCapacity { get; }
        IList<IPlane> SearchPlane(int from, int to);
        int TotalCapcity();
        double TotalLoadCapcity();
        void Sort(IComparer<IPlane> comparer);
        void Add(IPlane plane);
        void Remove(IPlane itemPlane);

    }
}
