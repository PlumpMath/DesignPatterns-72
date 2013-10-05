using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class SquackBehavior : IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("I am Squacking!!!!");
        }
    }
}
