using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data
{
    public interface IOrderItem : INotifyPropertyChanged
    {
        
        /// <summary>
        /// The price of the drink
        /// </summary>
        /// <value>
        /// In US dollars
        /// </value>
        double Price { get; }
        /// <summary>
        /// The calories of the drink
        /// </summary>
        uint Calories { get; }
        /// <summary>
        /// Special Instructions to prepare the drink
        /// </summary>
        List<string> SpecialInstructions { get; }

        string ToString();
    


    }
}
