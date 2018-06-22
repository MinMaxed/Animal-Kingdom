using AnimalKingdomOOP_Interface.Classes;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestInterface()
        {
            Mallard duck = new Mallard();

            Assert.True(duck.Migrates);
            Assert.False(duck.BreathesUnderWater);

        }

        [Fact]
        public void TestInheritance()
        {
            FruitBat bat = new FruitBat();
            Assert.True(bat.IsNocturnal);

        }

        [Fact]
        public void TestIsAnimal()
        {
            GreyWolves wolf = new GreyWolves();
            Assert.Equal("hhhhooooooooowwwwwllll", wolf.Sound());
            Assert.Equal("I live in the woods", wolf.Habitat());
            Assert.Equal("I eat what my pack catches.", wolf.Diet());
    }
    }
}
