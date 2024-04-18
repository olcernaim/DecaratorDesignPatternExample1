using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecaratorDesignPatternExample1
{
    public class SportsCar : CarDecorator
    {
        public SportsCar(ICar c) : base(c)
        {

        }

        public override void print()
        {
            base.print();
            this.X();
            Console.WriteLine(" Adding features of Sports Car");
        }

        public void X()
        {
            Console.WriteLine("A");
        }
    }
}
