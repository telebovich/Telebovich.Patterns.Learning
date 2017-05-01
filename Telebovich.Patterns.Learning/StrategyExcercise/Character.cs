using System;
using System.Collections.Generic;
using System.Text;

namespace Telebovich.Patterns.Learning.StrategyExcercise
{
    public abstract class Character
    {
        public IWeaponBehavior Weapon { get; set; }

        public abstract string Fight();
    }
}
