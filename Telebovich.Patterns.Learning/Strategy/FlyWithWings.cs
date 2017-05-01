using System;
using System.Collections.Generic;
using System.Text;

namespace Telebovich.Patterns.Learning.Strategy
{
    public class FlyWithWings : IFlyBehavior
    {
        public string Fly()
        {
            return "I'm flying!!";
        }
    }
}
