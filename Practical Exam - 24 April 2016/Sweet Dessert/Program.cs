using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweet_Dessert
{
    class Sweet_Dessert
    {
        static void Main()
        {
            double cash = double.Parse(Console.ReadLine());
            int guests = int.Parse(Console.ReadLine());
            double bananasPrice = double.Parse(Console.ReadLine());
            double eggsPrice = double.Parse(Console.ReadLine());
            double berriesPrice = double.Parse(Console.ReadLine());

            int numberOfSets = 0;
            int setsCheck = guests % 6;

            if (setsCheck != 0)
            {
                numberOfSets = guests / 6 + 1;
            }
            else
            {
                numberOfSets = guests / 6;
            }

            double setOfSix = 2*bananasPrice + 4*eggsPrice + 0.2*berriesPrice;
            double setsPrice = numberOfSets * setOfSix;

            if (setsPrice <= cash)
            {
                Console.WriteLine("Ivancho has enough money - it would cost {0:F2}lv.", setsPrice);
            }
            else
            {
                Console.WriteLine("Ivancho will have to withdraw money - he will need {0:F2}lv more.", Math.Abs(cash - setsPrice));
            }
        }
    }
}