using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data;
using System.ComponentModel;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;
using PointOfSale;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class ViewModelTest
    {
        [Fact]
        public void IsAssignableFromINotifyPropertyChanged()
        {
            ViewModel c = new ViewModel(1);
            Assert.IsAssignableFrom<INotifyPropertyChanged>(c);
        }
        [Fact]
        public void ChangingHunDollCustNotifiesHunDollCust()
        {
            ViewModel c = new ViewModel(1);
            Assert.PropertyChanged(c, "HunDollCust", () =>
            {
                c.HunDollCust = 1;
            });
        }
        [Fact]
        public void ChangingHunDollCustNotifiesAmountDue()
        {
            ViewModel c = new ViewModel(1);
            Assert.PropertyChanged(c, "AmountDue", () =>
            {
                c.HunDollCust = 1;
            });
        }
        [Fact]
        public void ChangingFiftyDollCustNotifiesAmountDue()
        {
            ViewModel c = new ViewModel(1);
            Assert.PropertyChanged(c, "AmountDue", () =>
            {
                c.FiftyDollCust = 1;
            });
        }
        [Fact]
        public void ChangingFiftyDollCustNotifiesFiftyDollCust()
        {
            ViewModel c = new ViewModel(1);
            Assert.PropertyChanged(c, "FiftyDollCust", () =>
            {
                c.FiftyDollCust = 1;
            });
        }
        [Fact]
        public void ChangingTwentyDollCustNotifiesTwentyDollCust()
        {
            ViewModel c = new ViewModel(1);
            Assert.PropertyChanged(c, "TwentyDollCust", () =>
            {
                c.TwentyDollCust = 1;
            });
        }
        [Fact]
        public void ChangingTwentyDollCustNotifiesAmountDue()
        {
            ViewModel c = new ViewModel(1);
            Assert.PropertyChanged(c, "AmountDue", () =>
            {
                c.TwentyDollCust = 1;
            });
        }

        [Fact]
        public void ChangingTenDollCustNotifiesAmountDue()
        {
            ViewModel c = new ViewModel(1);
            Assert.PropertyChanged(c, "AmountDue", () =>
            {
                c.TenDollCust = 1;
            });
        }
        [Fact]
        public void ChangingTenDollCustNotifiesTenDollCust()
        {
            ViewModel c = new ViewModel(1);
            Assert.PropertyChanged(c, "TenDolLCust", () =>
            {
                c.TenDollCust = 1;
            });
        }
        [Fact]
        public void ChangingFiveDollCustNotifiesAmountDue()
        {
            ViewModel c = new ViewModel(1);
            Assert.PropertyChanged(c, "AmountDue", () =>
            {
                c.FiveDollCust = 1;
            });
        }
        [Fact]
        public void ChangingFiveDollCustNotifiesFiveDollCust()
        {
            ViewModel c = new ViewModel(1);
            Assert.PropertyChanged(c, "FiveDollCust", () =>
            {
                c.FiveDollCust = 1;
            });
        }
        [Fact]
        public void ChangingTwoDollCustNotifiesAmountDue()
        {
            ViewModel c = new ViewModel(1);
            Assert.PropertyChanged(c, "AmountDue", () =>
            {
                c.TwoDollCust = 1;
            });
        }
        [Fact]
        public void ChangingTwoDollCustNotifiesTwoDollCust()
        {
            ViewModel c = new ViewModel(1);
            Assert.PropertyChanged(c, "TwoDollCust", () =>
            {
                c.TwoDollCust = 1;
            });
        }
        [Fact]
        public void ChangingOneDollCustNotifiesAmountDue()
        {
            ViewModel c = new ViewModel(1);
            Assert.PropertyChanged(c, "AmountDue", () =>
            {
                c.OneDollCust = 1;
            });
        }

        [Fact]
        public void ChangingOneDollCustNotifiesOneDollCust()
        {
            ViewModel c = new ViewModel(1);
            Assert.PropertyChanged(c, "OneDollCust", () =>
            {
                c.OneDollCust = 1;
            });
        }
        [Fact]
        public void ChangingFullDollCoinCustNotifiesAmountDue()
        {
            ViewModel c = new ViewModel(1);
            Assert.PropertyChanged(c, "AmountDue", () =>
            {
                c.FullDollCoinCust = 1;
            });
        }
        [Fact]
        public void ChangingFullDollCoinCustNotifiesFullDollCoinCust()
        {
            ViewModel c = new ViewModel(1);
            Assert.PropertyChanged(c, "FullDollCoinCust", () =>
            {
                c.FullDollCoinCust = 1;
            });
        }
        [Fact]
        public void ChangingHalfDollCustNotifiesAmountDue()
        {
            ViewModel c = new ViewModel(1);
            Assert.PropertyChanged(c, "AmountDue", () =>
            {
                c.HalfDollCust = 1;
            });
        }
        [Fact]
        public void ChangingHalfDollCustNotifiesHalfDollCust()
        {
            ViewModel c = new ViewModel(1);
            Assert.PropertyChanged(c, "HalfDollCust", () =>
            {
                c.HalfDollCust = 1;
            });
        }
        [Fact]
        public void ChangingQuartersCustNotifiesAmountDue()
        {
            ViewModel c = new ViewModel(1);
            Assert.PropertyChanged(c, "AmountDue", () =>
            {
                c.QuartersCust = 1;
            });
        }
        [Fact]
        public void ChangingQuartersCustNotifiesQuartersCust()
        {
            ViewModel c = new ViewModel(1);
            Assert.PropertyChanged(c, "QuartersCust", () =>
            {
                c.QuartersCust = 1;
            });
        }
        [Fact]
        public void ChangingDimesCustNotifiesAmountDue()
        {
            ViewModel c = new ViewModel(1);
            Assert.PropertyChanged(c, "AmountDue", () =>
            {
                c.DimesCust = 1;
            });
        }
        [Fact]
        public void ChangingDimesCustNotifiesDimesCust()
        {
            ViewModel c = new ViewModel(1);
            Assert.PropertyChanged(c, "DimesCust", () =>
            {
                c.DimesCust = 1;
            });
        }
        [Fact]
        public void ChangingNickelsCustNotifiesNickelsCust()
        {
            ViewModel c = new ViewModel(1);
            Assert.PropertyChanged(c, "NickelsCust", () =>
            {
                c.NickelsCust = 1;
            });
        }
        [Fact]
        public void ChangingNickelsCustNotifiesAmountDue()
        {
            ViewModel c = new ViewModel(1);
            Assert.PropertyChanged(c, "AmountDue", () =>
            {
                c.NickelsCust = 1;
            });
        }
        [Fact]
        public void ChangingPenniesCustNotifiesAmountDue()
        {
            ViewModel c = new ViewModel(1);
            Assert.PropertyChanged(c, "AmountDue", () =>
            {
                c.PenniesCust = 1;
            });
        }
        [Fact]
        public void ChangingPenniesCustNotifiesPenniesCust()
        {
            ViewModel c = new ViewModel(1);
            Assert.PropertyChanged(c, "PenniesCust", () =>
            {
                c.PenniesCust = 1;
            });
        }
    }
}
