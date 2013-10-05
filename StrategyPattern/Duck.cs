using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    abstract class Duck
    {
        public IFlyBehavior flyBehaviorObj { get; set; }
        public IQuackBehavior quackBehaviorObj { get; set; }

        public void PerformFly()
        {
            flyBehaviorObj.fly();
        }

        public void PerfromQuack()
        {
            quackBehaviorObj.quack();
        }

        public virtual void Swim()
        {
            Console.WriteLine("I am swimming!!!!!  -DUCk");
        }
    }
}
