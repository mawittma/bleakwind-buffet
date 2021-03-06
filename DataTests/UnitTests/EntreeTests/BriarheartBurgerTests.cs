﻿/*
 * Author: Zachery Brunner
 * Class: BriarheartBurgerTests.cs
 * Purpose: Test the BriarheartBurger.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class BriarheartBurgerTests
    {
        [Fact]
        public void ShouldReturnCorrectDescription()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.Equal("Single patty burger on a brioche bun. Comes with ketchup, mustard, pickle, and cheese.", bb.Description);
        }
        [Fact]
        public void IsAssignableFromINotifyPropertyChanged()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(bb);
        }
        [Fact]
        public void IsAssignableFromIOrderItem()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.IsAssignableFrom<IOrderItem>(bb);
        }
        [Fact]
        public void ChangingBunNotifiesBunProperty()
        {

            var bb = new BriarheartBurger();

            Assert.PropertyChanged(bb, "Bun", () =>
            {
                bb.Bun = false;
            });

            Assert.PropertyChanged(bb, "Bun", () =>
            {
                bb.Bun = true;
            });
        }
        [Fact]
        public void ChangingKetchupNotifiesKetchupProperty()
        {

            var bb = new BriarheartBurger();

            Assert.PropertyChanged(bb, "Ketchup", () =>
            {
                bb.Ketchup = false;
            });

            Assert.PropertyChanged(bb, "Ketchup", () =>
            {
                bb.Ketchup = true;
            });
        }
        [Fact]
        public void ChangingMustardNotifiesMustardProperty()
        {

            var bb = new BriarheartBurger();

            Assert.PropertyChanged(bb, "Mustard", () =>
            {
                bb.Mustard = false;
            });

            Assert.PropertyChanged(bb, "Mustard", () =>
            {
                bb.Mustard = true;
            });
        }
        [Fact]
        public void ChangingPickleNotifiesPickleProperty()
        {

            var bb = new BriarheartBurger();

            Assert.PropertyChanged(bb, "Pickle", () =>
            {
                bb.Pickle = false;
            });

            Assert.PropertyChanged(bb, "Pickle", () =>
            {
                bb.Pickle = true;
            });
        }
        [Fact]
        public void ChangingCheeseNotifiesCheeseProperty()
        {

            var bb = new BriarheartBurger();

            Assert.PropertyChanged(bb, "Cheese", () =>
            {
                bb.Cheese = false;
            });

            Assert.PropertyChanged(bb, "Cheese", () =>
            {
                bb.Cheese = true;
            });
        }
        [Fact]
        public void ShouldBeIOrderItem()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.IsAssignableFrom<IOrderItem>(bb);
        }
        [Fact]
        public void ShouldBeAEntree()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.IsAssignableFrom<Entree>(bb);
        }

        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.True(bb.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.True(bb.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.True(bb.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.True(bb.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.True(bb.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            BriarheartBurger bb = new BriarheartBurger();
            bb.Bun = false;
            Assert.False(bb.Bun);
            bb.Bun = true;
            Assert.True(bb.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            BriarheartBurger bb = new BriarheartBurger();
            bb.Ketchup = false;
            Assert.False(bb.Ketchup);
            bb.Ketchup = true;
            Assert.True(bb.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            BriarheartBurger bb = new BriarheartBurger();
            bb.Mustard = false;
            Assert.False(bb.Mustard);
            bb.Mustard = true;
            Assert.True(bb.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            BriarheartBurger bb = new BriarheartBurger();
            bb.Pickle = false;
            Assert.False(bb.Pickle);
            bb.Pickle = true;
            Assert.True(bb.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            BriarheartBurger bb = new BriarheartBurger();
            bb.Cheese = false;
            Assert.False(bb.Cheese);
            bb.Cheese = true;
            Assert.True(bb.Cheese);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.Equal(6.32, bb.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            BriarheartBurger bb = new BriarheartBurger();
            uint cal = 743;
            Assert.Equal(cal, bb.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true, true)]
        [InlineData(false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese)
        {
            BriarheartBurger bb = new BriarheartBurger();
            bb.Bun = includeBun;
            bb.Ketchup = includeKetchup;
            bb.Mustard = includeMustard;
            bb.Pickle = includePickle;
            bb.Cheese = includeCheese;

            if (!includeBun) Assert.Contains("Hold bun",bb.SpecialInstructions);
            if (!includeKetchup) Assert.Contains("Hold ketchup",bb.SpecialInstructions);
            if (!includeMustard) Assert.Contains("Hold mustard",bb.SpecialInstructions);
            if (!includePickle) Assert.Contains("Hold pickle",bb.SpecialInstructions);
            if (!includeCheese) Assert.Contains("Hold cheese",bb.SpecialInstructions);
            if (includeCheese && includeBun && includeKetchup && includeMustard && includePickle) Assert.Empty(bb.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            BriarheartBurger bb = new BriarheartBurger();
            string name = "Briarheart Burger";
            Assert.Equal(name, bb.ToString());
        }
    }
}