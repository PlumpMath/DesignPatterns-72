using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class NoFlyBehavior : IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("Sorry!! I can't fly - NoFlyBehavior");
        }
    }
}
