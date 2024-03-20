using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latihan_class_dan_object
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Taxi taxi = new Taxi();   

            taxi.Name = "Jono";
            taxi.OnDuty = true ;
            taxi.NumPassenger = 10;

            taxi.TaxiInfo();
            taxi.PickUp();
            taxi.DropOff();

            Console.ReadKey();
        }
    }
}
