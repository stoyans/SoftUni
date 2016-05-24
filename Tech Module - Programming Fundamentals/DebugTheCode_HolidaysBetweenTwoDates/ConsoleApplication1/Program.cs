namespace ConsoleApplication2
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            List<string> list = new List<string>();
            for (int i = 0; i < 129; i++)
            {
                string input = Console.ReadLine();
                Regex regex = new Regex(@"\s?(\d+)\s+(\d+)\s(\d+)\s+(\d+)");
                Match match = regex.Match(input);

                if (match.Success)
                {
                    list.Add(match.Groups[4].ToString());
                }
            }

            foreach (var palindrome in list)
            {
                Console.WriteLine(palindrome);
            }
        }
    }
}