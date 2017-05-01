using System;
using System.Collections.Generic;
using System.Text;

namespace Telebovich.Patterns.Learning.Strategy
{
    public class Quack : IQuackBehavior
    {
        public string DoQuack()
        {
            return "Quack!!";
        }
    }
}
