using System;
using System.Collections.Generic;
using System.Text;

namespace Telebovich.Patterns.Learning.Strategy
{
    public class MuteQuack : IQuackBehavior
    {
        public string DoQuack()
        {
            return "<< Silence >>";
        }
    }
}
