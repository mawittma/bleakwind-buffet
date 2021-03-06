﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// A class representing Vokun salad
    /// </summary>
    public class VokunSalad : Side , IOrderItem, INotifyPropertyChanged
    {
        //private variables for Vokun salad
        private Size size = Size.Small;
        public event PropertyChangedEventHandler PropertyChanged;
        public string Description
        {
            get { return "A seasonal fruit salad of mellons, berries, mango, grape, apple, and oranges."; }
        }
        /// <summary>
        /// The size of the salad
        /// </summary>
        public override Size Size
        {
            get { return size; }
            set {
                if (value == Size.Small && size != Size.Small)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                }
                else if (value == Size.Medium && size != Size.Medium)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                }
                else if (value == Size.Large && size != Size.Large)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                }
                size = value;
            }
        }
        /// <summary>
        /// The price of the salad based on size
        /// </summary>
        public override double Price
        {
            get
            {
                if (size == Size.Small)
                {
                    return .93;
                }
                else if (size == Size.Medium)
                {
                    return 1.28;
                }
                else
                {
                    return 1.82;
                }
            }
        }
        /// <summary>
        /// The Calories of the salad based size
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (size == Size.Small)
                {
                    return 41;
                }
                else if (size == Size.Medium)
                {
                    return 52;
                }
                else
                {
                    return 73;
                }
            }
        }
        /// <summary>
        /// A list of special instructions for the salad
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                return instructions;
            }
        }
        /// <summary>
        /// Returns a description of the salad
        /// </summary>
        /// <returns>a string to describe the salad</returns>
        public override string ToString()
        {
            return size + " Vokun Salad";
        }

    }
}
