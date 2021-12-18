using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_homework
{
    internal class Car : IDrive
    {
        public void Drive()
        {
            Console.WriteLine("Car drive");
        }
    }
}
