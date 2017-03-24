using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Methods
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Name(name);
        }

        static void Name(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
