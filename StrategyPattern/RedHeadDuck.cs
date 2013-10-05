using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class RedHeadDuck : Duck
    {
        public RedHeadDuck()
        {
            flyBehaviorObj = new RocketFlyBehavior();
            quackBehaviorObj = new SquackBehavior();
        }

        public override void Swim()
        {
            Console.WriteLine("I can override the duck's swimming style with my style - RedHeadDuck");
        }
    }
}
