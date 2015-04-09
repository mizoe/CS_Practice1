using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q24
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 15)
            {
                Console.Write(i);
                if (i % 3 == 0)
                {
                    Console.Write(" む!");
                }
                Console.WriteLine();
                i++;
            }
            Console.ReadLine();
        }
    }
}
