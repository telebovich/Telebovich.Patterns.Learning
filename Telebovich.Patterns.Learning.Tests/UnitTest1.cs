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

        [Fact]
        public void Model_Duck_Should_Not_Be_Able_To_Fly()
        {
            Duck model = new ModelDuck();

            string cantFly = model.PerformFly();

            Assert.Equal("I can't fly", cantFly);
        }

        [Fact]
        public void Model_Duck_Should_Change_Behavior()
        {
            Duck model = new ModelDuck();

            model.FlyBehavior = new FlyRocketPowered();

            string flyWithRocket = model.PerformFly();

            Assert.Equal("I'm flying with a rocket!", flyWithRocket);
        }

        [Fact]
        public void Mallard_Duck_Should_Be_Able_To_Display()
        {
            Duck mallard = new MallardDuck();

            string display = mallard.Display();

            Assert.Equal("I'm a real Mallard duck", display);
        }

        [Fact]
        public void Model_Duck_Should_Be_Able_To_Display()
        {
            Duck model = new ModelDuck();

            string display = model.Display();

            Assert.Equal("I'm a model duck!", display);
        }

        [Fact]
        public void Mallard_Duck_Should_Be_Able_To_Swim()
        {
            Duck mallard = new MallardDuck();

            string swim = mallard.Swim();

            Assert.Equal("All ducks float, even decoys!", swim);
        }

        [Fact]
        public void Model_Duck_Should_Be_Able_To_Swim()
        {
            Duck model = new ModelDuck();

            string swim = model.Swim();

            Assert.Equal("All ducks float, even decoys!", swim);
        }
    }
}
