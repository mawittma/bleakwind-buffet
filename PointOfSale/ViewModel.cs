using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using BleakwindBuffet.Data;
using RoundRegister;

namespace PointOfSale
{
    public class ViewModel : INotifyPropertyChanged
    {
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
        public ViewModel(double total)
        {
            orderTotal = total;
        }

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
        public int HunDollChange{ get; set; }
        public int FiftyDollChange { get; set; }
        public int TwentyDollChange { get; set; }
        public int TenDollChange { get; set; }
        public int FiveDollChange { get; set; }
        public int TwoDollChange { get; set; }
        public int OneDollChange { get; set; }

        public int OneDollCoinChange { get; set; }
        public int HalfDollChange { get; set; }
        public int QuartersChange { get; set; }
        public int DimesChange { get; set; }
        public int NickelsChange { get; set; }
        public int PenniesChange { get; set; }
        public double OrderTotal
        {
            get { return orderTotal; }
        }
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
        
        public double CustTotal
        {
            get
            {
                return hunDollCust * 100 + fiftyDollCust * 50 + twentyDollCust * 20 + tenDollCust * 10 + fiveDollCust * 5 +
                    twoDollCust * 2 + oneDollCust + fullDollCoinCust + halfDollsCust * .5 + quartersCust * .25 +
                    dimesCust * .1 + nickelCust * .05 + penniesCust * .01;
            }
        }
        

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
