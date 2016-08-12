using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni_Coffee_Orders
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            decimal totalPrice = 0;

            for (int orderCount = 0; orderCount < N; orderCount++)
            {
                decimal price = decimal.Parse(Console.ReadLine());
                string[] dateTime = Console.ReadLine().Split('/');
                int[] dateValues = dateTime.Select(int.Parse).ToArray();
                int capsulesCount = int.Parse(Console.ReadLine());
                int days = DateTime.DaysInMonth(dateValues[2], dateValues[1]);

                decimal monthPrice = days * capsulesCount * price;
                totalPrice += monthPrice;
                Console.WriteLine("The price for the coffee is: ${0:F2}", monthPrice);
            }

            Console.WriteLine("Total: ${0:F2}", totalPrice);
        }
    }
}
