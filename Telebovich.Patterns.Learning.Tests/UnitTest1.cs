using System;
using Xunit;

namespace Telebovich.Patterns.Learning.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Duck mallard = new MallardDuck();

            string quack = mallard.PerformQuack();

            Assert.Equal("Quack", quack);
        }
    }
}
