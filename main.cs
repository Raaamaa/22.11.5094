using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiApp;

namespace Main
{
    class main
    {
        static void Main(string[] args)
        {
            //membuat objek Taxi
            Taxi taxi = new Taxi();

            //set nilai properties
            taxi.DriverName = "Juan";
            taxi.OnDuty = true;
            taxi.NumPass = 10;

            //pemanggilan method
            taxi.taxiInfo();

            if (taxi.OnDuty == true)
            {
                taxi.pickUpPassenger();
            }
            else if (taxi.OnDuty == false)
            {
                taxi.dropOffPassenger();
            }

            Console.ReadKey();
        }
    }
}

