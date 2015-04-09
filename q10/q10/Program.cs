using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ages = { 18, 11, 30, 15, 55, 32, 10 };
            foreach (var age in ages)
            {
                Console.Write("{0,2}", age);
                if (age >=7 && age <=12)
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
