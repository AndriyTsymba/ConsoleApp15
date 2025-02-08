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
            string text = "Цей текст містить слово 'програмування' серед інших слів.";

            Func<string, string, bool> containsWord = (txt, word) => txt.Contains(word, StringComparison.OrdinalIgnoreCase);

            Console.WriteLine($"Чи містить текст слово 'програмування': {containsWord(text, "програмування")}");
        }
    }
}