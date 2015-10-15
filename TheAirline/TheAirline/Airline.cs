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
        public int Сapacity { get; private set; }
        public double LoadCapacity { get; private set; }

        public List<IPlane> SearchPlane(int from, int to)
        {
            return Planes.Where(plane => plane.FuelConsumption >= from && plane.FuelConsumption <= to).ToList();
        }

        public int TotalCapcity()
        {
            foreach (var plane in Planes)
            {
                if (plane.GetType() == typeof (PassengerPlane))
                {
                    var passenger = plane as PassengerPlane;

                    if (passenger != null)
                    {
                        Сapacity += passenger.Capacity;
                    }
                }
            }

            return Сapacity;
        }

        public double TotalLoadCapcity()
        {
            foreach (var plane in Planes)
            {
                if (plane.GetType() == typeof(TransportPlane))
                {
                    var transport = plane as TransportPlane;

                    if (transport != null)
                    {
                        LoadCapacity += transport.LoadCapacity;
                    }
                }
            }

            return LoadCapacity;
        }


        public void Sort()
        {
            Planes.Sort();
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
