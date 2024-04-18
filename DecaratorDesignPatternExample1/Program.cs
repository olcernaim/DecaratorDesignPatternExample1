using System;

namespace DecaratorDesignPatternExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            ICar sportsCar = new SportsCar(new BasicCar());

            sportsCar.print();

            ICar goodCar = new SportsCar(new GoodCar());

            goodCar.print();

            ICar sportsLuxuryCar = new SportsCar(new LuxuryCar( new BasicCar()));

            sportsLuxuryCar.print();
            //Console.WriteLine("Hello World!");
        }
    }
}
