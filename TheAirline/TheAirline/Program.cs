using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using TheAirline.Interfaces;

namespace TheAirline
{
    class MyComparator : IComparer<IPlane>
    {
        public int Compare(IPlane x, IPlane y)
        {
            return -x.Range.CompareTo(y.Range);
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Airline airline = new Airline("Newston", new List<IPlane>());
            MyComparator myComparator = new MyComparator();

            airline.Add(new TransportPlane("Su", 5000, 300, 5000));
            airline.Add(new PassengerPlane("Boing",2500,150,40));
            airline.Add(new PassengerPlane("Boing", 1500, 100, 80));
            airline.Add(new PrivatePlane("Nowbel", 3000, 30, "Bill Geits"));


            airline.Sort(myComparator);

            Console.WriteLine(airline);
            Console.WriteLine(airline.TotalCapcity());
            Console.WriteLine(airline.TotalLoadCapcity());

            Console.ReadKey();


        }
    }
}
