using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q27
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (j != 0)
                    {
                        Console.Write("+");
                    }
                    Console.Write(j);
                }
                sum += i;
                Console.WriteLine("=" + sum);
            }
            Console.ReadLine();
        }
    }
}
