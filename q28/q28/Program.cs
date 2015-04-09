using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("カウント 合計");
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("   {0,2}     {1,2}", i, sum);
                sum += i;
            }
            Console.ReadLine();
        }
    }
}
