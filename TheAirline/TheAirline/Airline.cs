using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheAirline.Interfaces;

namespace TheAirline
{
    class Airline : IAirline
    {
        public Airline(string airlineName, List<IPlane> planes)
        {
            AirlineName = airlineName;
            Planes = planes;
        }

        public string AirlineName { get; private set; }
        public List<IPlane> Planes { get; private set; }

        public int TotalCapcity()
        {
            throw new NotImplementedException();
        }

        public void Sort()
        {
            Planes.Sort();
        }

        public void Add(IPlane plane)
        {
            Planes.Add(plane);
        }

        public void Remove(int index)
        {
            Planes.RemoveAt(index);
        }
    }
}
