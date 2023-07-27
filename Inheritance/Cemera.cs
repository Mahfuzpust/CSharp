using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Cemera : Electronics
    {
        public double ZoomCapacity { get; set; }

        public void Display()
        {
            Console.WriteLine($"{Name}");
            Console.WriteLine($"{Model}");
            Console.WriteLine($"{ZoomCapacity}");
        }
    }
}
