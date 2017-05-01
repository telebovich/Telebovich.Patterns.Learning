using System;
using System.Collections.Generic;
using System.Text;

namespace Telebovich.Patterns.Learning.Strategy
{
    public class FlyRocketPowered : IFlyBehavior
    {
        public string Fly()
        {
            return "I'm flying with a rocket!";
        }
    }
}
