using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q20
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.Write("かねだ");
                for (int j = 0; j < i; j++)
                {
                    Console.Write("あ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
