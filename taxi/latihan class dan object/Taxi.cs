using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latihan_class_dan_object
{
    public class Taxi
    {
        public string Name { get; set; }
        public bool OnDuty { get; set; }    
        public float NumPassenger { get; set; }

        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name: {0}", Name);
            Console.WriteLine("On Duty: {0}", (OnDuty ? "Yes" : "No"));
            Console.WriteLine("Number of Passenger: {0}\n", NumPassenger);
        }
        public void PickUp()
        { Console.WriteLine("{0} Sedang menjemput penumpang", Name); }
        public void DropOff()
        {
            Console.WriteLine("{0} Selesai mengantar penumpang", Name);        
        }
    }
}
