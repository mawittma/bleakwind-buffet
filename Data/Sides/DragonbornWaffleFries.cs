﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// A class representing Dragonborn waffle fries
    /// </summary>
    public class DragonbornWaffleFries : Side, IOrderItem, INotifyPropertyChanged
    {
        //private variables for waffle fries
        private Size size = Size.Small;
        public event PropertyChangedEventHandler PropertyChanged;
        public string Description
        {
            get { return "Crispy fried potato waffle fries."; }
        }
        /// <summary>
        /// The size of the waffle fries
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
        /// The price of the waffle fries based on size
        /// </summary>
        public override double Price
        {
            get
            {
                if (size == Size.Small)
                {
                    return .42;
                }
                else if (size == Size.Medium)
                {
                    return .76;
                }
                else
                {
                    return .96;
                }
            }
        }
        /// <summary>
        /// Calories of waffle fries based on size
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (size == Size.Small)
                {
                    return 77;
                }
                else if (size == Size.Medium)
                {
                    return 89;
                }
                else
                {
                    return 100;
                }
            }
        }
        /// <summary>
        /// A list of special instructions for the waffle fries
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
        /// returns a description of the waffle fries
        /// </summary>
        /// <returns>a string to describe the waffle fries</returns>
        public override string ToString()
        {
            return size+ " Dragonborn Waffle Fries";
        }
    }
}
