using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data;
using System.ComponentModel;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class ComboTest
    {
        [Fact]
        public void IsAssignableFromINotifyPropertyChanged()
        {
            Combo c = new Combo();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(c);
        }
        [Fact]
        public void IsAssignableFromIOrderItem()
        {
            Combo c = new Combo();
            Assert.IsAssignableFrom<IOrderItem>(c);
        }
        [Fact]
        public void ChangingEntreeNotifiesPrice()
        {
            Combo c = new Combo();
            Assert.PropertyChanged(c, "Price", () =>
            {
                c.Entree = new BriarheartBurger();
            });
        }
        [Fact]
        public void ChangingEntreeNotifiesEntree()
        {
            Combo c = new Combo();
            Assert.PropertyChanged(c, "Entree", () =>
            {
                c.Entree = new BriarheartBurger();
            });
        }
        [Fact]
        public void ChangingEntreeNotifiesCalories()
        {
            Combo c = new Combo();
            Assert.PropertyChanged(c, "Calories", () =>
            {
                c.Entree = new BriarheartBurger();
            });
        }
        [Fact]
        public void ChangingEntreeNotifiesSpecialInstructions()
        {
            Combo c = new Combo();
            Assert.PropertyChanged(c, "SpecialInstructions", () =>
            {
                c.Entree = new BriarheartBurger();
            });
        }
        [Fact]
        public void ChangingSideNotifiesPrice()
        {
            Combo c = new Combo();
            Assert.PropertyChanged(c, "Price", () =>
            {
                c.Side = new DragonbornWaffleFries();
            });
        }
        [Fact]
        public void ChangingSideNotifiesSide()
        {
            Combo c = new Combo();
            Assert.PropertyChanged(c, "Side", () =>
            {
                c.Side = new DragonbornWaffleFries();
            });
        }
        [Fact]
        public void ChangingSideNotifiesCalories()
        {
            Combo c = new Combo();
            Assert.PropertyChanged(c, "Calories", () =>
            {
                c.Side = new DragonbornWaffleFries();
            });
        }
        [Fact]
        public void ChangingSideNotifiesSpecialInstructions()
        {
            Combo c = new Combo();
            Assert.PropertyChanged(c, "SpecialInstructions", () =>
            {
                c.Side = new DragonbornWaffleFries();
            });
        }

        [Fact]
        public void ChangingDrinkNotifiesPrice()
        {
            Combo c = new Combo();
            Assert.PropertyChanged(c, "Price", () =>
            {
                c.Drink = new WarriorWater();
            });
        }
        [Fact]
        public void ChangingDrinkNotifiesDrink()
        {
            Combo c = new Combo();
            Assert.PropertyChanged(c, "Drink", () =>
            {
                c.Drink = new WarriorWater();
            });
        }
        [Fact]
        public void ChangingDrinkNotifiesCalories()
        {
            Combo c = new Combo();
            Assert.PropertyChanged(c, "Calories", () =>
            {
                c.Drink = new WarriorWater();
            });
        }
        [Fact]
        public void ChangingDrinkNotifiesSpecialInstructions()
        {
            Combo c = new Combo();
            Assert.PropertyChanged(c, "SpecialInstructions", () =>
            {
                c.Drink = new WarriorWater();
            });
        }
    }
}
