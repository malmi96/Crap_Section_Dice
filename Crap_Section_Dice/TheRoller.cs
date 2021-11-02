using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Crap_Section_Dice
{
    class TheRoller //Automated statistic guy
    {
        private Dice dice;
        private readonly int noOfDice;
        private List<int> resultSequence;

        public TheRoller(int diceCount)
        {
            dice = new Dice();
            noOfDice = diceCount;
            resultSequence = new List<int>();
        }

        public int PerformRoll()
        {
            int result = 0;
            for (int i=0; i<noOfDice; i++)
            {
                result += dice.Roll();
            }
            if (CompareWithAdjacentValues(result))
            {
                PerformRoll();
            }
            if(resultSequence.Count > 0 && result == GetMostRepeatedValue())
            {
                PerformRoll();
            }
            resultSequence.Add(result);
            return result;
        }

        public List<int> GetResultSequence()
        {
            return resultSequence;
        }

        private bool CompareWithAdjacentValues(int generatedNumber) //To compare with adjacent values
        {
            if (resultSequence.Count >= 2 && (generatedNumber == resultSequence[resultSequence.Count - 1] && generatedNumber == resultSequence[resultSequence.Count - 2]))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private int GetMostRepeatedValue() //To get the most repeated value
        {
            var mostRepeatedNumber = resultSequence.GroupBy(i => i).OrderByDescending(grp => grp.Count()).Select(grp => grp.Key).First();
            return mostRepeatedNumber;
        }
    }
}
