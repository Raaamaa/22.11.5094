using Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiApp;

class Taxi
{

    //properties
    public string DriverName { get; set; }
    public bool OnDuty { get; set; }
    public int NumPass { get; set; }

    //method
    public void taxiInfo()
    {
        Console.WriteLine("Driver Name: {0}", DriverName);
        Console.WriteLine("On Duty: {0}", OnDuty);
        Console.WriteLine("Number of Passenger: {0}", NumPass);
    }
  
    public void pickUpPassenger()
    {
        Console.WriteLine("{0} sedang menjemput penumpang\n", DriverName);
    }

    public void dropOffPassenger()
    {
        Console.WriteLine("{0} selesai mengantar penumpang\n", DriverName);
    }
    
}
