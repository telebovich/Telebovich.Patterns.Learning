using System;
using System.Collections.Generic;
using System.Text;

namespace Telebovich.Patterns.Learning.Strategy
{
    public abstract class Duck
    {
        private IFlyBehavior _flyBehavior;
        private IQuackBehavior _quackBehavior;

        public IFlyBehavior FlyBehavior { get => _flyBehavior; set => _flyBehavior = value; }
        public IQuackBehavior QuackBehavior { get => _quackBehavior; set => _quackBehavior = value; }

        public string PerformQuack()
        {
            return QuackBehavior.DoQuack();
        }

        public string PerformFly()
        {
            return FlyBehavior.Fly();
        }

        public abstract string Display();

        public string Swim() => "All ducks float, even decoys!";
    }
}
