using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace countBetweenNum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите второе число: ");
            double b = Convert.ToDouble(Console.ReadLine());
            double result = 0;

            for (double i = a; a < b; a++)
            {
                if ((a % 2) != 0)
                {
                    Console.WriteLine("{0} ", a);
                }
                result += a;
            }

            Console.WriteLine("Сумма чисел равна: {0}", result);

            // Delay

            Console.ReadKey();
        }
    }
}
