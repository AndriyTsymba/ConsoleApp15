using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Program
    {

        static void Main()
        {
            Func<string, (int, int, int)> getRainbowColor = delegate (string color)
            {
                var colors = new Dictionary<string, (int, int, int)>
        {
                { "червоний", (255, 0, 0) },
                { "оранжевий", (255, 165, 0) },
                { "жовтий", (255, 255, 0) },
                { "зелений", (0, 128, 0) },
                { "блакитний", (0, 255, 255) },
                { "синій", (0, 0, 255) },
                { "фіолетовий", (128, 0, 128) }
        };

                return colors.ContainsKey(color.ToLower()) ? colors[color.ToLower()] : (0, 0, 0);
            };

            string[] rainbowColors = { "червоний", "оранжевий", "жовтий", "зелений", "блакитний", "синій", "фіолетовий" };

            foreach (var color in rainbowColors)
            {
                var (r, g, b) = getRainbowColor(color);
                Console.WriteLine($"{color} -> RGB({r}, {g}, {b})");
            }
        }
    }
}