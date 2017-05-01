using System;
using System.Collections.Generic;
using System.Text;

namespace Telebovich.Patterns.Learning.Strategy
{
    public class FlyNoWay : IFlyBehavior
    {
        public string Fly()
        {
            return "I can't fly";
        }
    }
}
