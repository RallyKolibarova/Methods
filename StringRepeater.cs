using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringRepeater
{
    class StringRepeater
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());
            string peace = RepeatString(word, number);
            Console.WriteLine(peace);
        }

        static string RepeatString(string str, int count)
        {
            string repeatedSrting = string.Empty;

            for(int i = 0; i < count; i++)
            {
                repeatedSrting += str;
            }
            return repeatedSrting;
        }
    }
}
