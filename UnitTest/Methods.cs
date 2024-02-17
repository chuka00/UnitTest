using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    public class Methods
    {
        public static void LogAction(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static string SquareToString(int x)
        {
            return (x * x).ToString();
        }


        public static IEnumerable<int> EvenSquaredNumbersAbove30()
        {
            List<int> numbers = Enumerable.Range(1, 10).ToList();

            Func<int, bool> isEven = x => x % 2 == 0;
            Func<int, int> square = x => x * x;

            var evenSquaredNumbersAbove30 = numbers
                .Where(isEven)
                .Select(square)
                .Where(x => x > 30);

            return evenSquaredNumbersAbove30;
        }

    }
}
