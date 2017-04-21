using System;
using System.Collections.Generic;
using System.Text;

namespace Telebovich.Patterns.Learning
{
    public class FlyNoWay : IFlyBehavior
    {
        public string Fly()
        {
            return "I can't fly";
        }
    }
}
