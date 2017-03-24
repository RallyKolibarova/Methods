using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodEncrypted
{
    class MethodEncrypted
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var result = string.Empty;

            for(int i = 0; i < n; i++)
            {
                var currentChar = char.Parse(Console.ReadLine());

                var encrypted = Encrypted(currentChar);

                result += encrypted;
            }
            Console.WriteLine(result);
        }

        static string Encrypted(char currentChar)
        {
            var asciiCode = (int)currentChar;
            var firstDigit = asciiCode;

            while(firstDigit >= 0)
            {
                firstDigit /= 
            }

        }
    }
}
