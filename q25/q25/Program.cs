using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q25
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 40)
            {
                Console.Write(i);
                bool hasThree = false;
                bool hasEight = false;
                if (i % 3 == 0 || i.ToString().Contains("3"))
                {
                    hasThree = true;
                }
                if (i % 8 == 0 || i.ToString().Contains("8"))
                {
                    hasEight = true;
                }
                if (hasThree == true)
                {
                    if (hasEight == true)
                    {
                        Console.Write(" 無駄無駄無駄無駄");
                    }
                    else
                    {
                        Console.Write(" む!");
                    }
                }
                else if (hasEight == true)
                {
                    Console.Write(" だ!");
                }
                Console.WriteLine();
                i++;
            }
            Console.ReadLine();
        }
    }
}
