using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntToBase
{
    class IntToBase
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            var toBase = int.Parse(Console.ReadLine());

            var converted = IntToBase(number, toBase);
            Console.WriteLine(converted);

        }

        static string IntToBase(int number, int toBase)
        {
            var result = string.Empty;

            while (number > 0)
            {
                var remainder = number % toBase;
                result = remainder + result;
                number /= toBase;
            }
            return result;
        }
    }
}
