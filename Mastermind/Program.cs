using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Mastermind;

namespace Mastermind
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string inputNumbers;
			StringBuilder plusMinusOutput = new StringBuilder();
			NumberGenerator numberGenerator = new NumberGenerator();
			string randomNumbers = numberGenerator.GetRandomNumbers().ToString();

            Console.WriteLine("WELCOME TO MASTERMIND!! LET'S PLAY!!\n");

            Console.WriteLine("Please enter FOUR numbers without spaces, between one and six, and then hit enter." +
                " You get 10 attempts to guess the right number sequence! If you guess a correct number in the correct order, " +
                "you will see a plus sign. If you guess a number that is in the sequence but is not in the correct order you will " +
                "see a minus sign. If you guess an incorrect number entirely, you will see a blank space.\n");

            for (int j = 0; j < 10; j++)
			{
				plusMinusOutput.Clear();
                bool fourNumbers = true;
                inputNumbers = Console.ReadLine();
                var charsInString = Regex.Matches(inputNumbers, @"[a-zA-Z]").Count;

                if (inputNumbers.Length != 4 || charsInString > 0 || inputNumbers.Contains(" "))
                {
                    fourNumbers = false;
                    Console.WriteLine("Please input exactly four numbers between one and six, no letters or spaces.");
                }

                while (fourNumbers)
                { 

                for (int i = 0; i < inputNumbers.Length; i++)
				{
					if (inputNumbers[i].Equals(randomNumbers[i]))
					{
						plusMinusOutput.Append("+");
					}
					else if(!inputNumbers[i].Equals(randomNumbers[i]) && randomNumbers.Contains(inputNumbers[i]))
					{
						plusMinusOutput.Append("-");
					}
					else
					{
						plusMinusOutput.Append(" ");
					}
				}
                if (plusMinusOutput.ToString().Equals("++++"))
                {
                    Console.WriteLine("Wooooo you won!!");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
				Console.WriteLine(plusMinusOutput);
                break;
                }
            }
			Console.WriteLine("You have reached the limit of 10 guesses without a correct guess. Better luck next time!");
            Console.ReadKey();
            Environment.Exit(0);
		}
    }
}
