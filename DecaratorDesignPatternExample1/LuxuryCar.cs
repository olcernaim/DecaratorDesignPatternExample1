using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecaratorDesignPatternExample1
{
    public class LuxuryCar : CarDecorator
    {
        public LuxuryCar(ICar c) : base(c)
        {

        }

        public override void print()
        {
            base.print();

            Console.WriteLine(" Adding features of Luxury Car");
        }
    }
}
