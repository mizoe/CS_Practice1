using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aを入力してください:");
            string input = Console.ReadLine();
            double a = double.Parse(input);

            Console.WriteLine("Bを入力してください:");
            input = Console.ReadLine();
            double b = double.Parse(input);

            if (a == b)
            {
                Console.WriteLine(a.ToString() + "と" + b.ToString() + "は等しい");
            }
            else if (a > b)
            {
                Console.WriteLine(a.ToString() + "は" + b.ToString() + "より大きい");
            }
            else
            {
                Console.WriteLine(a.ToString() + "は" + b.ToString() + "より小さい");
            }
            Console.ReadLine();
        }
    }
}
