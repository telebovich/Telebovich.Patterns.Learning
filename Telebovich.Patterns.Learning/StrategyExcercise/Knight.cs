using System;
using System.Collections.Generic;
using System.Text;

namespace Telebovich.Patterns.Learning.StrategyExcercise
{
    public class Knight : Character
    {
        public Knight()
        {
            Weapon = new BowAndArrowBehavior();
        }

        public override string Fight()
        {
            return Weapon.UseWeapon();
        }
    }
}
