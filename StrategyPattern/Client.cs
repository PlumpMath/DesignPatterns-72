using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Client
    {
        public static void Main(string[] args)
        {
            RubberDuck rduck = new RubberDuck();
            rduck.PerformFly();
            rduck.PerfromQuack();

            Console.WriteLine("Adding RocketFly behavior to the rubber duck");
            rduck.flyBehaviorObj = new RocketFlyBehavior();

            rduck.PerformFly();

            Console.ReadLine();
        }
    }
}
