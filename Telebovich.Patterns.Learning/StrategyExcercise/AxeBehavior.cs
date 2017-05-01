using System;
using System.Collections.Generic;
using System.Text;

namespace Telebovich.Patterns.Learning.StrategyExcercise
{
    public class AxeBehavior : IWeaponBehavior
    {
        public string UseWeapon()
        {
            return "Chop";
        }
    }
}
