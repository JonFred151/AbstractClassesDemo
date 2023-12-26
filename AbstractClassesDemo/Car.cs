using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesDemo
{
    internal class Car: Vehicle
    {
        public bool HasTrunk { get; set; }
        public override void DriveAbstract()
        {
            Console.WriteLine("Car is Driving");
        }
    }
}
