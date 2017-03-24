using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NthDigit
{
    class NthDigit
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            int index = int.Parse(Console.ReadLine());    

            int result = FindNthDigit(number, index);
               
            Console.WriteLine(result);


        }

        static int FindNthDigit(long number, int index)
        {
            int currentIndex = 1;
            while(number > 0)
            {
                if (currentIndex == index)
                {
                    return (int)number % 10;
                }
                currentIndex++;
                number /= 10;
            }
            return (int)number % 10;
        } 

    }
}
