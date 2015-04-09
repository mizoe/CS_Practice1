using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testAges = new int[20];

            for (int i = 0; i < testAges.Length; i++)
            {
                testAges[i] = i;
            }

            foreach (var age in testAges)
            {
                Console.Write("{0,2}", age);
                if (age >= 7 && age <= 12)
                {
                    Console.Write(" 小学生");
                }
                else if (age >= 13 && age <= 15)
                {
                    Console.Write(" 中学生");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
