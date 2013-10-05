using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class RocketFlyBehavior : IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I can fly like a rocket - RocketFlyBehavior");
        }
    }
}
