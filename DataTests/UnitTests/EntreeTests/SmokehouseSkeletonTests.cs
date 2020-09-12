/*
 * Author: Zachery Brunner
 * Class: SmokehouseSkeletonTests.cs
 * Purpose: Test the SmokehouseSkeleton.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class SmokehouseSkeletonTests
    {
        [Fact]
        public void ShouldBeIOrderItem()
        {
            SmokehouseSkeleton shs = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<IOrderItem>(shs);
        }
        [Fact]
        public void ShouldBeAEntree()
        {
            SmokehouseSkeleton shs = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<Entree>(shs);
        }
        [Fact]
        public void ShouldInlcudeSausageByDefault()
        {
            SmokehouseSkeleton shs = new SmokehouseSkeleton();
            Assert.True(shs.SausageLink);
        }

        [Fact]
        public void ShouldInlcudeEggByDefault()
        {
            SmokehouseSkeleton shs = new SmokehouseSkeleton();
            Assert.True(shs.Egg);
        }

        [Fact]
        public void ShouldInlcudeHashbrownsByDefault()
        {
            SmokehouseSkeleton shs = new SmokehouseSkeleton();
            Assert.True(shs.Hashbrowns);
        }

        [Fact]
        public void ShouldInlcudePancakeByDefault()
        {
            SmokehouseSkeleton shs = new SmokehouseSkeleton();
            Assert.True(shs.Pancake);
        }

        [Fact]
        public void ShouldBeAbleToSetSausage()
        {
            SmokehouseSkeleton shs = new SmokehouseSkeleton();
            shs.SausageLink = false;
            Assert.False(shs.SausageLink);
            shs.SausageLink = true;
            Assert.True(shs.SausageLink);
        }

        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            SmokehouseSkeleton shs = new SmokehouseSkeleton();
            shs.Egg = false;
            Assert.False(shs.Egg);
            shs.Egg = true;
            Assert.True(shs.Egg);
        }

        [Fact]
        public void ShouldBeAbleToSetHashbrowns()
        {
            SmokehouseSkeleton shs = new SmokehouseSkeleton();
            shs.Hashbrowns = false;
            Assert.False(shs.Hashbrowns);
            shs.Hashbrowns = true;
            Assert.True(shs.Hashbrowns);
        }

        [Fact]
        public void ShouldBeAbleToSetPancake()
        {
            SmokehouseSkeleton shs = new SmokehouseSkeleton();
            shs.Pancake = false;
            Assert.False(shs.Pancake);
            shs.Pancake = true;
            Assert.True(shs.Pancake);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            SmokehouseSkeleton shs = new SmokehouseSkeleton();
            Assert.Equal(5.62, shs.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            SmokehouseSkeleton shs = new SmokehouseSkeleton();
            uint cal = 602;
            Assert.Equal(cal, shs.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSausage, bool includeEgg,
                                                            bool includeHashbrowns, bool includePancake)
        {
            SmokehouseSkeleton shs = new SmokehouseSkeleton();
            shs.SausageLink = includeSausage;
            shs.Egg = includeEgg;
            shs.Hashbrowns = includeHashbrowns;
            shs.Pancake = includePancake;
            if (!includeSausage) Assert.Contains("Hold sausage", shs.SpecialInstructions);
            if (!includeEgg) Assert.Contains("Hold eggs", shs.SpecialInstructions);
            if (!includeHashbrowns) Assert.Contains("Hold hash browns", shs.SpecialInstructions);
            if (!includePancake) Assert.Contains("Hold pancakes", shs.SpecialInstructions);
            if (includeSausage && includeEgg && includeHashbrowns && includePancake) Assert.Empty(shs.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            SmokehouseSkeleton shs = new SmokehouseSkeleton();
            string name = "Smokehouse Skeleton";
            Assert.Equal(name, shs.ToString());
        }
    }
}