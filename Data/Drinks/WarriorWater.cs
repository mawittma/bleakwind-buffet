using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// A class representing warrior water
    /// </summary>
    public class WarriorWater : Drink, IOrderItem, INotifyPropertyChanged
    {
        //private variables for warrior water
        private bool ice = true;
        private bool lemon = false;
        private Size size = Size.Small;
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// If warrioir water has ice in it
        /// </summary>
        public bool Ice
        {
            get { return ice; }
            set {
                if (value == true && ice == false)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));

                }
                else if (value == false && ice == true)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
                }

                ice = value;
            }
        }
        /// <summary>
        /// The size of the water
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
        /// If there is lemon in the water
        /// </summary>
        public bool Lemon
        {
            get { return lemon; }
            set {
                if (value == true && lemon == false)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lemon"));

                }
                else if (value == false && lemon == true)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lemon"));
                }

                lemon = value;
            }
        }
        /// <summary>
        /// The price of the water based on size
        /// </summary>
        public override double Price
        {
            get
            {
                return 0;
            }
        }
        /// <summary>
        /// The calories of the water
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 0;
            }
        }
        /// <summary>
        /// A list of special instructions for the water
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice)
                {
                    instructions.Add("Hold ice");
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
                if (Lemon)
                {
                    instructions.Add("Add lemon");
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
                return instructions;
            }
        }
        /// <summary>
        /// Returns the description of the water
        /// </summary>
        /// <returns>a string that describes the water</returns>
        public override string ToString()
        {
            return size + " Warrior Water";
        }
    }
}