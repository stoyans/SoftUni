using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Numbers
{
    class Numbers
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');

            List<int> nums = input.Select(int.Parse).ToList();
            var sortedNums = nums.OrderBy(x => -x);
            var average = sortedNums.Average();
            var largest5Nums = sortedNums.Where(x => x > average).Take(5);

            List<int> array = largest5Nums.ToList();
            if (array.Count == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine(string.Join(" ", largest5Nums));
            }
            

        }
    }
}
