using System;
using System.Collections.Generic;
using System.Linq;

namespace Largest_Common_End
{
    class Largest_Common_End
    {
        static void Main()
        {
            string firstLine = Console.ReadLine();
            string secondLine = Console.ReadLine();

            string resultText = String.Empty;
            int arraySize = Math.Min(firstLine.Length, secondLine.Length);

            for (int i = 0; i < arraySize - 1; i++)
            {
                if (firstLine[i] == secondLine[i])
                {
                    resultText += firstLine[i];
                }
            }
        }
    }
}
