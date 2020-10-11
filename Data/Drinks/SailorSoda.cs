using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// A class representing Sailor Soda
    /// </summary>
    public class SailorSoda : Drink, IOrderItem, INotifyPropertyChanged
    {
        //private variables for Sailor Soda
        private bool ice = true;
        private Size size = Size.Small;
        private SodaFlavor flavor = SodaFlavor.Cherry;
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// If there is ice in the Sailor Soda
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
        /// The size of the soda
        /// </summary>
        public override Size Size
        {
            get { return size; }
            set {
                if (value == Size.Small && size != Size.Small)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                }
                else if (value == Size.Medium && size != Size.Medium)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                }
                else if (value == Size.Large && size != Size.Large)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                }
                size = value;
            }
        }
        /// <summary>
        /// The flavor of the sailor soda
        /// </summary>
        public SodaFlavor Flavor
        {
            get { return flavor; }
            set {
                if (value == SodaFlavor.Cherry && flavor != SodaFlavor.Cherry)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Flavor"));
                }
                else if (value == SodaFlavor.Blackberry && flavor != SodaFlavor.Blackberry)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Flavor"));
                }
                else if (value == SodaFlavor.Grapefruit && flavor != SodaFlavor.Grapefruit)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Flavor"));
                }else if(value == SodaFlavor.Lemon && flavor != SodaFlavor.Lemon)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Flavor"));
                }else if(value == SodaFlavor.Peach && flavor != SodaFlavor.Peach)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Flavor"));
                }else if(value == SodaFlavor.Watermelon && flavor != SodaFlavor.Watermelon)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Flavor"));
                }
                flavor = value;
            }
        }
        /// <summary>
        /// The price of the soda based on size
        /// </summary>
        public override double Price
        {
            get
            {
                if (size == Size.Small)
                {
                    return 1.42;
                }
                else if (size == Size.Medium)
                {
                    return 1.74;
                }
                else
                {
                    return 2.07;
                }
            }
        }
        /// <summary>
        /// The calories of the soda based on size
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (size == Size.Small)
                {
                    return 117;
                }
                else if (size == Size.Medium)
                {
                    return 153;
                }
                else
                {
                    return 205;
                }
            }
        }
        /// <summary>
        /// A list of special instructions for the soda
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice)
                {
                    instructions.Add("Hold ice");
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }

                return instructions;
            }
        }
        /// <summary>
        /// returns a description of the soda
        /// </summary>
        /// <returns>a string to describe the soda</returns>
        public override string ToString()
        {

            return size + " " + flavor + " Sailor Soda";
            
            
        }
    }
}
