using System;
using System.Collections.Generic;
using System.Text;

namespace Telebovich.Patterns.Learning
{
    public class MallardDuck: Duck
    {
        public MallardDuck()
        {
            quackBehavior = new Quack();
            flyBehavior = new FlyWithWings();
        }
    }
}
