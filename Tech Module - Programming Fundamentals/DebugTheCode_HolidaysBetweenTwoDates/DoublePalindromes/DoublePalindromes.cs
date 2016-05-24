using System;
using System.Collections.Generic;

namespace DoublePalindromes
{
    class DoublePalindromes
    {
        static void Main()
        {
            String[] palindromes = new String[129];
            int count = 0;

            for (int i = 0; true; i++)
            {
                string number = i.ToString();
                string binary = Convert.ToString(i, 2);
                bool isPal = CheckPalindromes(number);

                if (isPal == false)
                {
                    continue;
                }

                bool isBinaryPalindrome = CheckPalindromes(binary);
                if (isPal == true && isBinaryPalindrome == true)
                {
                    Console.WriteLine(number);
                    palindromes[count] = number;
                    count++;
                    if (palindromes.Length == 128)
                    {
                        break;
                    }
                }
            }
        }

        static bool CheckPalindromes(string value)
        {
            bool isPalindrome = true;
            int reverse = value.Length - 1;
            

            for (int position = 0; position < value.Length; position++)
            {

                if (value[position] != value[reverse])
                {
                    isPalindrome = false;
                    break;
                }

                reverse--;
            }

            return isPalindrome;
        }
    }
}
