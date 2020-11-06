using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle()
        {

        }

        public bool HasSideCart { get; set; } = false;
        public override void DriveAbstract()
        {
            Console.WriteLine("This motorcycle is in drive!");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine($"This {GetType().Name} is a {GetType().BaseType.Name} that's virtually in drive.");
        }
    }
}
