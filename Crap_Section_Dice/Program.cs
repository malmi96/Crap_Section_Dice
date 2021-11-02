using System;

namespace Crap_Section_Dice
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter Number of Dice");
            var input = Console.ReadLine();
            Console.WriteLine("Number of dice for crap = " + input);
            var Roller = new TheRoller(Int32.Parse(input));

            Console.WriteLine("Press Y to Roll");

            while (Console.ReadLine().Equals("Y", StringComparison.OrdinalIgnoreCase))
            {
                var value = Roller.PerformRoll();
                Console.WriteLine("Your generated value = " + value);
                Console.WriteLine("Press Y to Roll again or any other key to exit");
            }

            var roller = Roller.GetResultSequence();
            Console.WriteLine("This is the sequence:");

            for (int i=0; i<roller.Count; i++)
            {
                Console.WriteLine(roller[i]);
            }

        }
    }
}
