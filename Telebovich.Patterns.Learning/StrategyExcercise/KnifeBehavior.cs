using System;
using System.Collections.Generic;
using System.Text;

namespace Telebovich.Patterns.Learning.StrategyExcercise
{
    public class KnifeBehavior : IWeaponBehavior
    {
        public string UseWeapon()
        {
            return "Cut";
        }
    }
}
