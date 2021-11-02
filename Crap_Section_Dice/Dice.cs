using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Crap_Section_Dice
{
    public class Dice // Automated dice
    {
        public int DiceCount { get; set; }
        private Random rand;

        public Dice()
        {
            rand = new Random();
        }

        public int Roll()
        {
            return rand.Next(1,6);
        }
    }
}
