using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using TheAirline.Interfaces;

namespace TheAirline
{
    class Program
    {
        static void Main(string[] args)
        {
            Airline airline = new Airline("Newston", new List<IPlane>());

            airline.Add(new TransportPlane("Su", 5000, 300, 5000));
            airline.Add(new PassengerPlane("Boing",2500,150,40));
            airline.Add(new PassengerPlane("Boing", 2500, 100, 80));
            airline.Add(new PrivatePlane("Nowbel", 1000, 30, "Bill Geits"));

            Console.WriteLine(airline);


            Console.ReadKey();


        }
    }
}
