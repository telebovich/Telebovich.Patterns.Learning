using System;
using Xunit;

namespace Telebovich.Patterns.Learning.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Should_Be_Able_To_Quack()
        {
            Quack quackBehavior = new Quack();

            string quack = quackBehavior.DoQuack();

            Assert.Equal("Quack!!", quack);
        }

        [Fact]
        public void Mallard_Duck_Should_Be_Able_To_Quack()
        {
            Duck mallard = new MallardDuck();

            string quack = mallard.PerformQuack();

            Assert.Equal("Quack!!", quack);
        }

        [Fact]
        public void Should_Be_Able_To_Fly_With_Wings()
        {
            FlyWithWings flyWithWings = new FlyWithWings();

            string fly = flyWithWings.Fly();

            Assert.Equal("I'm flying!!", fly);
        }

        [Fact]
        public void Mallard_Duck_Should_Be_Able_To_Fly_With_Wings()
        {
            Duck mallardDuck = new MallardDuck();

            string flying = mallardDuck.PerformFly();

            Assert.Equal("I'm flying!!", flying);
        }

        [Fact]
        public void Should_Be_Able_To_Say_Fly_No_Way()
        {
            FlyNoWay cantFly = new FlyNoWay();

            string noWay = cantFly.Fly();

            Assert.Equal("I can't fly", noWay);
        }

        [Fact]
        public void Should_Be_Able_To_Say_Nothing()
        {
            MuteQuack mute = new MuteQuack();

            string silence = mute.DoQuack();

            Assert.Equal("<< Silence >>", silence);
        }
    }
}
