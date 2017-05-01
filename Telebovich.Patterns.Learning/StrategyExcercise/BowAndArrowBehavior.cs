using System;
using System.Collections.Generic;
using System.Text;

namespace Telebovich.Patterns.Learning.StrategyExcercise
{
    public class BowAndArrowBehavior : IWeaponBehavior
    {
        public string UseWeapon()
        {
            return "Shoot";
        }
    }
}
