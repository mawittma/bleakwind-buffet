﻿using System;
using BleakwindBuffet.Data.Enums;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// A base class representing the common proporties of sides
    /// </summary>
    public abstract class Side
    {
        /// <summary>
        /// the size of the drink
        /// </summary>
        public abstract Size Size { get; set; }
        /// <summary>
        /// The price of the drink
        /// </summary>+
        /// <value>
        /// In US dollars
        /// </value>
        public abstract double Price { get; }
        /// <summary>
        /// The calories of the drink
        /// </summary>
        public abstract uint Calories { get; }
        /// <summary>
        /// Special Instructions to prepare the drink
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
