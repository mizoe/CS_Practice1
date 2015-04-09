using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("年齢を入力してください:");
            string input = Console.ReadLine();
            uint age = uint.Parse(input);

            Console.WriteLine("身長を入力してください:");
            input = Console.ReadLine();
            uint height = uint.Parse(input);

            if (age >= 6 && height >= 120)
            {
                Console.WriteLine("乗れます");
            }
            else
            {
                Console.WriteLine("乗れません");
            }
            Console.ReadLine();
        }
    }
}
