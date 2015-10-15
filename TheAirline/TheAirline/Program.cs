using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TheAirline.Interfaces;

namespace TheAirline
{
    class Program
    {
        static void Main(string[] args)
        {
            Airline airline = new Airline("Newston", new List<IPlane>());


            airline.Add(new PassengerPlane("Boing",2500,100,40));
            airline.Add(new TransportPlane("Su",5000,200,5000));

        }
    }
}
