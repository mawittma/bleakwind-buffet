using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class for representing a Arentino Apple Juice Drink
    /// </summary>
    public class ArentinoAppleJuice : Drink, IOrderItem, INotifyPropertyChanged
    {
        //private variables for Arentino Apple juice
        private bool ice = false;
        private Size size = Size.Small;
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// If this apple juice has ice in it
        /// </summary>
        public bool Ice
        {
            get { return ice; }
            set 
            { 
                if(value == true && ice == false)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
                    
                }else if(value == false && ice == true)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
                }

                ice = value; 
            }
        }
        /// <summary>
        /// The size of the apple juice
        /// </summary>
        public override Size Size
        {
            get { return size; }
            set 
            { 
                if(value == Size.Small && size != Size.Small)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                }
                else if(value == Size.Medium && size != Size.Medium)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                }
                else if(value == Size.Large && size != Size.Large)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                }
                size = value; 
            }
        }
        public string Description
        {
            get { return "Fresh squeezed apple juice."; }
        }
        /// <summary>
        /// The price of the apple juice based on its size
        /// </summary>
        public override double Price
        {
            get
            {
                if(size == Size.Small)
                {
                    return .62;
                }else if(size == Size.Medium)
                {
                    return .87;
                }
                else
                {
                    return 1.01;
                }
            }
        }
        /// <summary>
        /// The calories of the apple juice based on the size
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (size == Size.Small)
                {
                    return 44;
                }
                else if (size == Size.Medium)
                {
                    return 88;
                }
                else
                {
                    return 132;
                }
            }
        }
        /// <summary>
        /// Returns a list of special instructions for the apple juice
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice)
                {
                    instructions.Add("Add ice");
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
                
                return instructions;
            }
        }
        /// <summary>
        /// Returns a description of the apple juice
        /// </summary>
        /// <returns>a string describing the apple juice</returns>
        public override string ToString()
        {
           
            return size +" Arentino Apple Juice";
 
        }
    }
}
