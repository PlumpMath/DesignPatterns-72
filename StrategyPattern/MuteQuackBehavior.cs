using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class MuteQuackBehavior : IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Sorry!!! I can't quack -MuteQuackBehavior ");
        }
    }
}
