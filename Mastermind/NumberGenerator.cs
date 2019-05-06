using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind
{
	public class NumberGenerator
	{
		public StringBuilder GetRandomNumbers()
        {
            StringBuilder randomNumbers = new StringBuilder();
			Random generatedNumber = new Random();

			for (int i = 1; i < 5; i++)
            {
                randomNumbers.Append(generatedNumber.Next(1,7));
            }

            return randomNumbers;
        }
	}
}
