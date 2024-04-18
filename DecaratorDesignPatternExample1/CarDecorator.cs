using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecaratorDesignPatternExample1
{
    public class CarDecorator : ICar
    {
        protected ICar car;

        public CarDecorator(ICar c)
        {
            this.car = c;
        }
        public virtual void print()
        {
            this.car.print();
        }
    }
}
