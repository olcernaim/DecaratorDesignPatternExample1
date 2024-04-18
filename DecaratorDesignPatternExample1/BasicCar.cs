using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecaratorDesignPatternExample1
{
    public class BasicCar : ICar
    {
        public void print()
        {
            Console.WriteLine("Basic car.");
        }
    }
}
