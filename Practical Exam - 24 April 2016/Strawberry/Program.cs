using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strawberry
{
    class Strawberry
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());

            int width = N * 2 + 3;
            int topHieght = N / 2;

            Console.Write(new string('\\', 1));
            Console.Write(new string('-', N));
            Console.Write(new string('|', 1));
            Console.Write(new string('-', N));
            Console.Write(new string('/', 1));
            Console.WriteLine();

            for (int i = 0; i < topHieght - 1; i++)
            {
                Console.Write(new string('-', (i+1)*2));
                Console.Write(new string('\\', 1));
                Console.Write(new string('-', width / 2 - (i + 1) * 2 - 1));
                Console.Write(new string('|', 1));
                Console.Write(new string('-', width / 2 - (i + 1) * 2 - 1));
                Console.Write(new string('/', 1));
                Console.Write(new string('-', (i + 1) * 2));
                Console.WriteLine();
            }

            Console.Write(new string('-', N));
            Console.Write(new string('#', 1));
            Console.Write(new string('.', 1));
            Console.Write(new string('#', 1));
            Console.Write(new string('-', N));
            Console.WriteLine();

            int middleDots = 5;

            for (int i = 0; i < topHieght; i++)
            {
                Console.Write(new string('-', N - 2 - 2*i));
                Console.Write(new string('#', 1));
                Console.Write(new string('.', middleDots + i * 2));
                Console.Write(new string('#', 1));
                Console.Write(new string('-', N - 2 - 2 * i));
                Console.WriteLine();
                middleDots += 2;
            }

            Console.Write(new string('#', 1));
            Console.Write(new string('.', width - 2));
            Console.Write(new string('#', 1));
            Console.WriteLine();

            middleDots = 1;

            for (int i = 0; i < N - 1; i++)
            {
                Console.Write(new string('-', i + 1));
                Console.Write(new string('#', 1));
                Console.Write(new string('.', N * 2 - middleDots - i));
                Console.Write(new string('#', 1));
                Console.Write(new string('-', i + 1));
                Console.WriteLine();
                middleDots += 1;
            }

            Console.Write(new string('-', N));
            Console.Write(new string('#', 1));
            Console.Write(new string('.', 1));
            Console.Write(new string('#', 1));
            Console.Write(new string('-', N));
            Console.WriteLine();
        }
    }
}
