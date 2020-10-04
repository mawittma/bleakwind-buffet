using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A class representing a Philly Poacher
    /// </summary>
    public class PhillyPoacher :Entree, IOrderItem, INotifyPropertyChanged
    {
        // private variables for the philly poacher
        private bool sirloin = true;
        private bool onion = true;
        private bool roll = true;
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// If there is sirloin in the philly
        /// </summary>
        public bool Sirloin
        {
            get { return sirloin; }
            set {
                if (value == true && sirloin == false)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Sirloin"));

                }
                else if (value == false && sirloin  == true)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Sirloin"));
                }

                sirloin = value;
            }
        }
        /// <summary>
        /// If there is onion in your philly
        /// </summary>
        public bool Onion
        {
            get { return onion; }
            set {
                if (value == true && onion == false)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Onion"));

                }
                else if (value == false && onion == true)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Onion"));
                }

                onion = value;
            }
        }
        /// <summary>
        /// If there is a roll with philly
        /// </summary>
        public bool Roll
        {
            get { return roll; }
            set {
                if (value == true && roll == false)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Roll"));

                }
                else if (value == false && roll == true)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Roll"));
                }

                roll = value;
            }
        }
        /// <summary>
        /// The price of the philly
        /// </summary>
        public override double Price
        {
            get { return 7.23; }
        }
        /// <summary>
        /// The calories of the philly
        /// </summary>
        public override uint Calories
        {
            get { return 784; }
        }
        /// <summary>
        /// A list of special instructions for the philly
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Sirloin) instructions.Add("Hold sirloin");
                if (!Onion) instructions.Add("Hold onions");
                if (!Roll) instructions.Add("Hold roll");
                return instructions;
            }
        }
        /// <summary>
        /// Returns a description of the philly
        /// </summary>
        /// <returns>a string to describe the philly</returns>
        public override string ToString()
        {
            return "Philly Poacher";
        }
    }
}
