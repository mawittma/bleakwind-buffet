using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// a class representing the thugs TBone
    /// </summary>
    public class ThugsTBone : Entree, IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// The price of TBone
        /// </summary>
        public override double Price
        {
            get { return 6.44; }
        }
        /// <summary>
        /// The calories of the TBone
        /// </summary>
        public override uint Calories
        {
            get { return 982; }
        }
        /// <summary>
        /// A list for special instructions for TBone
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
        /// Returns a description of TBone
        /// </summary>
        /// <returns>a string to describe TBone</returns>
        public override string ToString()
        {
            return "Thugs T-Bone";
        }
    }
}
