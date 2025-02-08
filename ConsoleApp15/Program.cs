using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main()
        {
            int[] numbers = { -7, 14, 21, -3, 49, 7, 5, 14, -7, 28, 35, -35, 0, 42, -42 };

            Func<int[], int> countMultiplesOfSeven = arr => arr.Count(n => n % 7 == 0 && n != 0);

            Console.WriteLine($"Кількість чисел, кратних 7: {countMultiplesOfSeven(numbers)}");
        }
    }
}