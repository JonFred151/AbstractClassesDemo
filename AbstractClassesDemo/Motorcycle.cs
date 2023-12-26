using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesDemo
{
    internal class Motorcycle: Vehicle
    {
        public bool HasSidecart { get; set; }
        public override void DriveAbstract()
        {
            Console.WriteLine("The motorcycle is driving");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("Motorcycle Virtual drive method");
        }
    }
}
