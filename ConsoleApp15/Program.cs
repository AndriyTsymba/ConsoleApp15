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

            Action<int[]> showUniqueNegativeNumbers = arr =>
            {
                var uniqueNegatives = arr.Where(n => n < 0).Distinct();
                Console.WriteLine("Унікальні негативні числа: " + string.Join(", ", uniqueNegatives));
            };

            showUniqueNegativeNumbers(numbers);
        }
    }

}