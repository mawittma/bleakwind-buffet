/*
 * Author: Zachery Brunner
 * Class: ThugsTBoneTests.cs
 * Purpose: Test the ThugsTBone.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class ThugsTBoneTests
    {
        [Fact]
        public void ShouldReturnCorrectDescription()
        {
            ThugsTBone ttb = new ThugsTBone();
            Assert.Equal("Juicy T-Bone, not much else to say.", ttb.Description);
        }
        [Fact]
        public void IsAssignableFromINotifyPropertyChanged()
        {
            ThugsTBone ttb = new ThugsTBone();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(ttb);
        }
        [Fact]
        public void IsAssignableFromIOrderItem()
        {
            ThugsTBone ttb = new ThugsTBone();
            Assert.IsAssignableFrom<IOrderItem>(ttb);
        }
        [Fact]
        public void ShouldBeIOrderItem()
        {
            ThugsTBone ttb = new ThugsTBone();
            Assert.IsAssignableFrom<IOrderItem>(ttb);
        }
        [Fact]
        public void ShouldBeAEntree()
        {
            ThugsTBone ttb = new ThugsTBone();
            Assert.IsAssignableFrom<Entree>(ttb);
        }
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            ThugsTBone ttb = new ThugsTBone();
            Assert.Equal(6.44, ttb.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            ThugsTBone ttb = new ThugsTBone();
            uint cal = 982;
            Assert.Equal(cal, ttb.Calories);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            ThugsTBone ttb = new ThugsTBone();
            Assert.Empty(ttb.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            string name = "Thugs T-Bone";
            ThugsTBone ttb = new ThugsTBone();
            Assert.Equal(name, ttb.ToString());
        }
    }
}