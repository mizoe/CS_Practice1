using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("年齢を入力してください:");
            string input = Console.ReadLine();
            uint age = uint.Parse(input);
            if (age >= 16 && age <= 69)
            {
                Console.WriteLine("献血できます");
            }
            else
            {
                Console.WriteLine("献血できません");
            }
            Console.ReadLine();
        }
    }
}
