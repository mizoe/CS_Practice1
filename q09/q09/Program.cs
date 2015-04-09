using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q09
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ages = { 18, 11, 30, 15, 55, 32, 10 };
            foreach (var age in ages)
            {
                Console.Write("{0,2}", age);
                if (age >= 20)
                {
                    Console.Write(" 成人");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
