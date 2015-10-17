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
        public IList<IPlane> Planes { get; private set; }
        public int Сapacity { get; private set; }
        public double LoadCapacity { get; private set; }

        public IList<IPlane> SearchPlane(int from, int to)
        {
            return Planes.Where(plane => plane.FuelConsumption >= from && plane.FuelConsumption <= to).ToList();
        }

        public int TotalCapcity()
        {
            Сapacity = Planes.Where(x => x is IPassenger).Cast<IPassenger>().Sum(x => x.Capacity);

            return Сapacity;
        }

        public double TotalLoadCapcity()
        {
            LoadCapacity = Planes.Where(x => x is ITransport).Cast<ITransport>().Sum(x => x.LoadCapacity);

            return LoadCapacity;
        }


        public void Sort(IComparer<IPlane> comparer)
        {
            Planes = Planes.OrderBy((x => x),comparer).ToList();
        }

        public void Add(IPlane plane)
        {
            Planes.Add(plane);
        }

        public void Remove(IPlane itemPlane)
        {
            Planes.Remove(itemPlane);
        }

        public override string ToString()
        {
            StringBuilder information = new StringBuilder();

            information.Append("Airline Name : " + AirlineName + "\n\n");

            foreach (var plane in Planes)
            {
                information.Append(plane + "\n");
            }

            return information.ToString();
        }
    }
}
