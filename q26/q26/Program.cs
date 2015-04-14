using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q26
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (IsPrime(i))
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }

        static bool IsPrime(int n)
        {
            if (n < 2)
            {
                return false;
            }
            else if (n == 2)
            {
                return true;
            }

            if (n % 2 == 0)
            {
                return false;
            }

            for (int j = 3; j <= n / j; j += 2)
            {
                if (n % j == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
