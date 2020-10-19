using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using BleakwindBuffet.Data;
using RoundRegister;

namespace PointOfSale
{
    /// <summary>
    /// ViewModel class of MVVM class architechture
    /// </summary>
    public class ViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// Property Changed Event
        /// all private backing variables
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        private int penniesCust = 0;
        private int nickelCust = 0;
        private int dimesCust = 0;
        private int quartersCust = 0;
        private int halfDollsCust = 0;
        private int fullDollCoinCust = 0;
        private int oneDollCust = 0;
        private int twoDollCust = 0;
        private int fiveDollCust = 0;
        private int tenDollCust = 0;
        private int twentyDollCust = 0;
        private int fiftyDollCust = 0;
        private int hunDollCust = 0;
        private double changeOwed = 0;

        
        private double orderTotal;
        /// <summary>
        /// constructor of the ViewModel Class
        /// </summary>
        /// <param name="total"></param>
        public ViewModel(double total)
        {
            orderTotal = total;
        }
        
        /// <summary>
        /// Determines what the worker should give back the customer in change
        /// </summary>
        public void WhatToReturn()
        {
            changeOwed = ChangeOwed;
            if(changeOwed / 100 >= 1)
            {
                double temp = changeOwed / 100;
                temp = Math.Floor(temp);
                changeOwed = changeOwed - (temp * 100);
                HunDollChange = (int)temp;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HunDollChange"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
            }
            if (changeOwed / 50 >= 1)
            {
                double temp = changeOwed / 50;
                temp = Math.Floor(temp);
                changeOwed = changeOwed - (temp * 50);
                FiftyDollChange = (int)temp;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FiftyDollChange"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
            }
            if (changeOwed / 20 >= 1)
            {
                double temp = changeOwed / 20;
                temp = Math.Floor(temp);
                changeOwed = changeOwed - (temp * 20);
                TwentyDollChange = (int)temp;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TwentyDollChange"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
            }
            if (changeOwed / 10 >= 1)
            {
                double temp = changeOwed / 10;
                temp = Math.Floor(temp);
                changeOwed = changeOwed - (temp * 10);
                TenDollChange = (int)temp;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TenDollChange"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
            }
            if (changeOwed / 5 >= 1)
            {
                double temp = changeOwed / 5;
                temp = Math.Floor(temp);
                changeOwed = changeOwed - (temp * 5);
                FiveDollChange = (int)temp;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FiveDollChange"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
            }
            if (changeOwed / 2 >= 1)
            {
                double temp = changeOwed / 2;
                temp = Math.Floor(temp);
                changeOwed = changeOwed - (temp * 2);
                TwoDollChange = (int)temp;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TwoDollChange"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
            }
            if (changeOwed / 1 >= 0)
            {
                double temp = changeOwed / 1;
                temp = Math.Floor(temp);
                changeOwed = changeOwed - (temp * 1);
                OneDollChange = (int)temp;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OneDollChange"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
            }
            if((changeOwed*100) / 50 >= 1)
            {
                double temp = changeOwed * 100;
                temp = temp / 50;
                temp = Math.Floor(temp);
                changeOwed = changeOwed - (.5 * temp);
                NickelsChange = (int)temp;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HalfDollChange"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
            }
            if ((changeOwed * 100) / 25 >= 1)
            {
                double temp = changeOwed * 100;
                temp = temp / 25;
                temp = Math.Floor(temp);
                changeOwed = changeOwed - (.25 * temp);
                NickelsChange = (int)temp;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("QuartersChange"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
            }
            if ((changeOwed * 100) / 10 >= 1)
            {
                double temp = changeOwed * 100;
                temp = temp / 10;
                temp = Math.Floor(temp);
                changeOwed = changeOwed - (.1*temp);
                DimesChange =(int) temp;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("DimesChange"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
            }
            if ((changeOwed * 100) / 5 >= 1)
            {
                double temp = changeOwed * 100;
                temp = temp / 5;
                temp = Math.Floor(temp);
                changeOwed = changeOwed - (.05 * temp);
                NickelsChange = (int)temp;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("NickelsChange"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
            }
            if ((changeOwed * 100) / 1 >= 1)
            {
                double temp = changeOwed * 100;
                temp = temp / 1;
                temp = Math.Floor(temp);
                changeOwed = changeOwed - (.01 * temp);
                PenniesChange = (int)temp;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PenniesChange"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
            }


        }
        /// <summary>
        /// the amount of Hundred Dollar bills in change
        /// </summary>
        public int HunDollChange{ get; set; }
        /// <summary>
        ///the amount of Fifty Dollar bills in change
        /// </summary>
        public int FiftyDollChange { get; set; }
        /// <summary>
        /// the amount of Twenty Dollar bills in change
        /// </summary>
        public int TwentyDollChange { get; set; }
        /// <summary>
        /// the amount of Ten Dollar bills in change
        /// </summary>
        public int TenDollChange { get; set; }
        /// <summary>
        /// the amount of Five Dollar bills in change
        /// </summary>
        public int FiveDollChange { get; set; }
        /// <summary>
        /// the amount of two Dollar bills in change
        /// </summary>
        public int TwoDollChange { get; set; }
        /// <summary>
        /// the amount of One Dollar bills in change
        /// </summary>
        public int OneDollChange { get; set; }

        /// <summary>
        /// the amount of one Dollar coins in change
        /// </summary>
        public int OneDollCoinChange { get; set; }
        /// <summary>
        /// the amount of half Dollar coins in change
        /// </summary>
        public int HalfDollChange { get; set; }
        /// <summary>
        /// the amount of quarters in change
        /// </summary>
        public int QuartersChange { get; set; }
        /// <summary>
        /// the amount of Dimes in change
        /// </summary>
        public int DimesChange { get; set; }
        /// <summary>
        /// the amount of nickels in change
        /// </summary>
        public int NickelsChange { get; set; }
        /// <summary>
        /// the amount of pennies in change
        /// </summary>
        public int PenniesChange { get; set; }
        /// <summary>
        /// the order total
        /// </summary>
        public double OrderTotal
        {
            get { return orderTotal; }
        }
        /// <summary>
        /// the change owed to customer
        /// </summary>
        public double ChangeOwed
        {
            get
            {
                if(CustTotal - orderTotal > 0)
                {
                    return CustTotal -orderTotal;
                }
                else
                {
                    return changeOwed;
                }
            }
            set
            {
                changeOwed = value;
            }
            
        }
        /// <summary>
        /// amount the customer must pay
        /// </summary>
        public double AmountDue
        {
            get
            {
                if(OrderTotal - CustTotal > 0 )
                {
                    return OrderTotal - CustTotal;
                }
                else
                {
                    if(CustTotal - orderTotal > 0)
                    {
                        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
                    }
                    WhatToReturn();
                    return 0;
                }
            }
        }
        /// <summary>
        /// customer Total that he has payed in
        /// </summary>
        
        public double CustTotal
        {
            get
            {
                return hunDollCust * 100 + fiftyDollCust * 50 + twentyDollCust * 20 + tenDollCust * 10 + fiveDollCust * 5 +
                    twoDollCust * 2 + oneDollCust + fullDollCoinCust + halfDollsCust * .5 + quartersCust * .25 +
                    dimesCust * .1 + nickelCust * .05 + penniesCust * .01;
            }
        }
        
        /// <summary>
        /// the amount of hundred dollar bills the customer gave
        /// </summary>

        public int HunDollCust
        {
            get { return hunDollCust; }
            set
            {
                if (value != hunDollCust)
                {
                    hunDollCust = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HunDollCust"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                }
            }
        }
        /// <summary>
        /// the amount of hundred fifty bills the customer gave
        /// </summary>
        public int FiftyDollCust
        {
            get { return fiftyDollCust; }
            set
            {
                if (value != fiftyDollCust)
                {
                    fiftyDollCust = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FiftyDollCust"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                }
            }
        }
        /// <summary>
        /// the amount of Twenty dollar bills the customer gave
        /// </summary>
        public int TwentyDollCust
        {
            get { return twentyDollCust; }
            set
            {
                if (value != twentyDollCust)
                {
                    twentyDollCust = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TwentyDollCust"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                }
            }
        }
        /// <summary>
        /// the amount of Ten dollar bills the customer gave
        /// </summary>
        public int TenDollCust
        {
            get { return tenDollCust; }
            set
            {
                if (value != tenDollCust)
                {
                    tenDollCust = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TenDollCust"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                }
            }
        }
        /// <summary>
        /// the amount of five dollar bills the customer gave
        /// </summary>
        public int FiveDollCust
        {
            get { return fiveDollCust; }
            set
            {
                if (value != fiveDollCust)
                {
                    fiveDollCust = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FiveDollCust"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                }
            }
        }
        /// <summary>
        /// the amount of two dollar bills the customer gave
        /// </summary>
        public int TwoDollCust
        {
            get { return twoDollCust; }
            set
            {
                if (value != twoDollCust)
                {
                    twoDollCust = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TwoDollCust"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                }
            }
        }
        /// <summary>
        /// the amount of one dollar bills the customer gave
        /// </summary>
        public int OneDollCust
        {
            get { return oneDollCust; }
            set
            {
                if (value != oneDollCust)
                {
                    oneDollCust = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OneDollCust"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                }
            }
        }
        /// <summary>
        /// the amount of pennies the customer gave
        /// </summary>

        public int PenniesCust
        {
            get { return penniesCust; }
            set
            {
                if(value!= penniesCust)
                {
                    penniesCust = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PenniesCust"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                }
            }
        }
        /// <summary>
        /// the amount of Nickels the customer gave
        /// </summary>
        public int NickelsCust
        {
            get { return nickelCust; }
            set
            {
                if (value != nickelCust)
                {
                    nickelCust = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("NickelsCust"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                }
            }
        }
        /// <summary>
        /// the amount of dimes the customer gave
        /// </summary>
        public int DimesCust
        {
            get { return dimesCust; }
            set
            {
                if (value != dimesCust)
                {
                    dimesCust = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("DimesCust"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                }
            }
        }
        /// <summary>
        /// the amount of Quarters the customer gave
        /// </summary>
        public int QuartersCust
        {
            get { return quartersCust; }
            set
            {
                if (value !=quartersCust)
                {
                    quartersCust = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("QuartersCust"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                }
            }
        }
        /// <summary>
        /// the amount of half dollars the customer gave
        /// </summary>
        public int HalfDollCust
        {
            get { return halfDollsCust; }
            set
            {
                if (value != halfDollsCust)
                {
                    halfDollsCust = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HalfDollCust"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                }
            }
        }
        /// <summary>
        /// the amount of dollar coins the customer gave
        /// </summary>
        public int FullDollCoinCust
        {
            get { return fullDollCoinCust; }
            set
            {
                if (value != fullDollCoinCust)
                {
                    fullDollCoinCust = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FullDollCoinCust"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                }
            }
        }

        
    }
}
