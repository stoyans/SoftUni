using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Modifier
{
    class Array_Modifier

    {
        static void Main()
        {
            string[] inputArray = Console.ReadLine().Split();
            string inputCommand = String.Empty;
            long [] digitArray = new long[inputArray.Length];

            for (int i = 0; i < digitArray.Length; i++)
			{
                digitArray[i] = int.Parse(inputArray[i]);
			}

            while (true)
	        {
                inputCommand = Console.ReadLine();
                if (inputCommand == "end")
                {
                    break;   
                }
                string[] commandArray = inputCommand.Split();
                string command = commandArray[0];

                if (inputCommand != "decrease")
	            {
		            int index1 = int.Parse(commandArray[1]);
                    int index2 = int.Parse(commandArray[2]);

                    if (command == "swap")
	                {
                        long currentValue = digitArray[index1];
                        digitArray[index1] = digitArray[index2];
                        digitArray[index2] = currentValue;
	                }
                    if (command == "multiply")
	                {
                        long product = digitArray[index1] * digitArray[index2];
		                digitArray[index1] = product;
	                }
	            }
                else
                {
                    for (int i = 0; i < digitArray.Length; i++)
			        {
                        digitArray[i] -= 1;
			        }
                }
            }

            for (int i = 0; i < digitArray.Length; i++)
			{
                if (i > 0)
                {
                    Console.Write(", ");
                } 
                Console.Write(digitArray[i]);
			}
            Console.WriteLine();
        }
    }
}
