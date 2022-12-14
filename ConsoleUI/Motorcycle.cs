using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Motorcycle : Vehical
    {
        public bool HasShideCart { get; set; }
        public override void DriveAbstract()
        {
            Console.WriteLine("The Motorcycle is Driving");
            Console.WriteLine("The Motorcyle shifts Smooth");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine("Motorcycle's Virtual drive Method");
        }
    }
}
