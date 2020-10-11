using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;

namespace BleakwindBuffet.Data
{
    public class Combo: IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private Entree entree = null;
        private Side side = null;
        private Drink drink = null;
        
        /// <summary>
        /// A entree for the combo
        /// </summary>
        public Entree Entree
        {
            get { return entree; }
            set
            {
                if(entree != value)
                {
                    entree = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Entree"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
            }
        }
        /// <summary>
        /// A side for the combo
        /// </summary>
        public Side Side
        {
            get { return side; }
            set
            {
                if(side != value)
                {
                    side = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Side"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
            }
        }
        /// <summary>
        /// A drink for the combo
        /// </summary>
        public Drink Drink
        {
            get { return drink; }
            set
            {
                if(drink != value)
                {
                    drink = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Drink"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }    
            }
        }
        /// <summary>
        /// The price of the combo
        /// </summary>
        public double Price
        {
            get { return side.Price + drink.Price + entree.Price - 1; }
        }
        /// <summary>
        /// The calories of the combo
        /// </summary>
        public uint Calories
        {
            get { return side.Calories + drink.Calories + entree.Calories - 1; }
        }
        /// <summary>
        /// A list of special instructions for the combo
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                instructions.Add(entree.ToString());
                foreach(string s in entree.SpecialInstructions)
                {
                    instructions.Add(s);
                }
                instructions.Add(side.ToString());
                foreach (string s in side.SpecialInstructions)
                {
                    instructions.Add(s);
                }
                instructions.Add(drink.ToString());
                foreach (string s in drink.SpecialInstructions)
                {
                    instructions.Add(s);
                }
                return instructions;
            }
        }

    }
}
