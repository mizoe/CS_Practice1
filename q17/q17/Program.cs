using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q17
{
    class Program
    {
        static void Main(string[] args)
        {
            uint score;
            string input = "";
            while (uint.TryParse(input, out score) == false)
            {
                Console.WriteLine("成績を入力してください:");
                input = Console.ReadLine();
            }

            if (score >= 80)
            {
                Console.WriteLine("A判定");
            }
            else if (score >= 70)
            {
                Console.WriteLine("B判定");
            }
            else if (score >= 60)
            {
                Console.WriteLine("C判定");
            }
            else
            {
                Console.WriteLine("D判定");
            }
            Console.ReadLine();
        }
    }
}
