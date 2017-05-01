﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Telebovich.Patterns.Learning.StrategyExcercise
{
    public class King : Character 
    {
        public King()
        {
            Weapon = new SwordBehavior();
        }

        public override string Fight()
        {
            return Weapon.UseWeapon();
        }
    }
}
