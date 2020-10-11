using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A class to represent the garden orc omelette
    /// </summary>
    public class GardenOrcOmelette : Entree, IOrderItem, INotifyPropertyChanged
    {
        // private variables for the garden orc omelette
        private bool broccoli = true;
        private bool mushrooms = true;
        private bool tomato = true;
        private bool cheddar = true;
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// If there is broccoli in the omelette
        /// </summary>
        public bool Broccoli
        {
            get { return broccoli; }
            set 
            {
                if (value == true && broccoli == false)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Broccoli"));

                }
                else if (value == false && broccoli == true)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Broccoli"));
                }

                broccoli = value;
            }
        }
        /// <summary>
        /// If there is mushrooms in the omelette
        /// </summary>
        public bool Mushrooms
        {
            get { return mushrooms; }
            set 
            {
                if (value == true && mushrooms == false)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mushrooms"));

                }
                else if (value == false && mushrooms == true)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mushrooms"));
                }

                mushrooms = value;
            }
        
        }
        /// <summary>
        /// If there is tomato in the omelette
        /// </summary>
        public bool Tomato
        {
            get { return tomato; }
            set {
                if (value == true && tomato == false)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tomato"));

                }
                else if (value == false && tomato == true)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tomato"));
                }

                tomato = value;
            }
        }
        /// <summary>
        /// If there is cheddar on the omelette
        /// </summary>
        public bool Cheddar
        {
            get { return cheddar; }
            set {
                if (value == true && cheddar == false)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheddar"));

                }
                else if (value == false && cheddar == true)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheddar"));
                }

                cheddar = value;
            }
        }
        /// <summary>
        /// The price of the omelette
        /// </summary>
        public override double Price
        {
            get { return 4.57; }
        }
        /// <summary>
        /// The calories of the omelette
        /// </summary>
        public override uint Calories
        {
            get { return 404; }
        }
        /// <summary>
        /// A list of the special instructions for the omelette
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get 
            {
                List<string> instructions = new List<string>();
                if (!Broccoli)
                {
                    instructions.Add("Hold broccoli");
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
                if (!Mushrooms)
                {
                    instructions.Add("Hold mushroom");
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
                if (!Tomato)
                {
                    instructions.Add("Hold tomato");
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
                if (!Cheddar)
                {
                    instructions.Add("Hold cheddar");
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
                return instructions; 
            }
        }
        /// <summary>
        /// Returns the description of the omelette
        /// </summary>
        /// <returns>a string to describe the omelette</returns>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }
    }
}
