using System;
using System.Collections.Generic;
using System.Text;

namespace Telebovich.Patterns.Learning
{
    public class Duck
    {
        protected IFlyBehavior flyBehavior;
        protected IQuackBehavior quackBehavior;

        public string PerformQuack()
        {
            return quackBehavior.DoQuack();
        }

        public string PerformFly()
        {
            return flyBehavior.Fly();
        }
    }
}
