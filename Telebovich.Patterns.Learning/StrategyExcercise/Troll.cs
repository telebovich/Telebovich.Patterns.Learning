using System;
using System.Collections.Generic;
using System.Text;

namespace Telebovich.Patterns.Learning.StrategyExcercise
{
    public class Troll : Character
    {
        public Troll()
        {
            Weapon = new AxeBehavior();
        }

        public override string Fight()
        {
            return Weapon.UseWeapon();
        }
    }
}
