using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A class to represent Thalmor Triple
    /// </summary>
    public class ThalmorTriple : Entree, IOrderItem, INotifyPropertyChanged
    {
        // private variables for thalmor triple
        private bool bun = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool pickle = true;
        private bool cheese = true;
        private bool tomato = true;
        private bool lettuce = true;
        private bool mayo = true;
        private bool bacon = true;
        private bool egg = true;
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// if there is a bun with thalmor triple
        /// </summary>
        public bool Bun
        {
            get { return bun; }
            set {
                if (value == true && bun == false)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bun"));

                }
                else if (value == false && bun == true)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bun"));
                }

                bun = value;
            }
        }
        /// <summary>
        /// if there is ketchup on the thalmor triple
        /// </summary>
        public bool Ketchup
        {
            get { return ketchup; }
            set {
                if (value == true && ketchup == false)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ketchup"));

                }
                else if (value == false && ketchup == true)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ketchup"));
                }

                ketchup = value;
            }
        }
        /// <summary>
        /// if there is mustard in the thalmor triple
        /// </summary>
        public bool Mustard
        {
            get { return mustard; }
            set {
                if (value == true && mustard == false)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mustard"));

                }
                else if (value == false && mustard == true)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mustard"));
                }

                mustard = value;
            }
        }
        /// <summary>
        /// if there is pickles in the triple
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set {
                if (value == true && pickle == false)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pickle"));

                }
                else if (value == false && pickle == true)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pickle"));
                }

                pickle = value;
            }
        }
        /// <summary>
        /// if there is cheese on the triple
        /// </summary>
        public bool Cheese
        {
            get { return cheese; }
            set {
                if (value == true && cheese == false)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheese"));

                }
                else if (value == false && cheese == true)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheese"));
                }

                cheese = value;
            }
        }
        /// <summary>
        /// if there is tomato on the triple
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
        /// if there is lettuce on the triple
        /// </summary>
        public bool Lettuce
        {
            get { return lettuce; }
            set {
                if (value == true && lettuce == false)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lettuce"));

                }
                else if (value == false && lettuce == true)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lettuce"));
                }

                lettuce = value;
            }
        }
        /// <summary>
        /// if there is mayo on the triple
        /// </summary>
        public bool Mayo
        {
            get { return mayo; }
            set {
                if (value == true && mayo == false)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mayo"));

                }
                else if (value == false && mayo == true)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mayo"));
                }

                mayo = value;
            }
        }
        /// <summary>
        /// if there is bacon on the triple
        /// </summary>
        public bool Bacon
        {
            get { return bacon; }
            set {
                if (value == true && bacon == false)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bacon"));

                }
                else if (value == false && bacon == true)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bacon"));
                }

                bacon = value;
            }
        }
        /// <summary>
        /// if there is an egg on the triple
        /// </summary>
        public bool Egg
        {
            get { return egg; }
            set {
                if (value == true && egg == false)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Egg"));

                }
                else if (value == false && egg == true)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Egg"));
                }

                egg = value;
            }
        }
        /// <summary>
        /// the price of the triple
        /// </summary>
        public override double Price
        {
            get { return 8.32; }
        }
        /// <summary>
        /// the calories of the triple
        /// </summary>
        public override uint Calories
        {
            get { return 943; }
        }
        /// <summary>
        /// a list of special instructions for the triple 
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Bun) instructions.Add("Hold bun");
                if (!Ketchup) instructions.Add("Hold ketchup");
                if (!Mustard) instructions.Add("Hold mustard");
                if (!Pickle) instructions.Add("Hold pickle");
                if (!Cheese) instructions.Add("Hold cheese");
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Lettuce) instructions.Add("Hold lettuce");
                if (!Mayo) instructions.Add("Hold mayo");
                if (!Bacon) instructions.Add("Hold bacon");
                if (!Egg) instructions.Add("Hold egg");
                return instructions;
            }
        }
        /// <summary>
        /// returns the description of the thalmor triple
        /// </summary>
        /// <returns>a string to describe thalmor triple</returns>
        public override string ToString()
        {
            return "Thalmor Triple";
;
        }
    }
}
