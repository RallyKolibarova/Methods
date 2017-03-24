using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMethod
{
    class MinMethod
    {
        static void Main(string[] args)
        {
            int numberFirst = int.Parse(Console.ReadLine());
            int numberSecond = int.Parse(Console.ReadLine());
            int numberThird = int.Parse(Console.ReadLine());
            GetMethod(numberFirst, numberSecond, numberThird);
        }

        private static void GetMethod(int a, int b, int c)
        {
            int temp = 0;
            if (a < b && b < c)
            {
                temp = a;
            }
            else if(a > b && a < c && b < c)
            {
                temp = b;
            }
            else if(c < a && c < b)
            {
                temp = c;
            }
            Console.WriteLine(temp);
        }
    }
}
