using System;
using System.Collections.Generic;
using System.Text;

namespace Telebovich.Patterns.Learning.StrategyExcercise
{
    public class Queen : Character
    {
        public Queen()
        {
            Weapon = new KnifeBehavior();
        }

        public override string Fight()
        {
            return Weapon.UseWeapon();
        }
    }
}
