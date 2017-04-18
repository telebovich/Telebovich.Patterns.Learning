using System;
using System.Collections.Generic;
using System.Text;

namespace Telebovich.Patterns.Learning
{
    public class Quack : IQuackBehavior
    {
        public string DoQuack()
        {
            return "Quack!!";
        }
    }
}
