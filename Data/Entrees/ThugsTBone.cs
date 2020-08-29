﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    class ThugsTBone
    {
        public double Price
        {
            get { return 6.44; }
        }
        public uint Calories
        {
            get { return 982; }
        }
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                return instructions;
            }
        }
        public override string ToString()
        {
            return "Thugs T-Bone";
        }
    }
}
