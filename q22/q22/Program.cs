using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q22
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 0; i <= 100; i++)
            {
                if (i % 4 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine("0から100までの数字のなかで4の倍数の合計は" + sum);
            Console.ReadLine();
        }
    }
}
