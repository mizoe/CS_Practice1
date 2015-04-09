using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q16
{
    class Program
    {
        static void Main(string[] args)
        {
            uint stock;
            string input = "";
            while (uint.TryParse(input, out stock) == false)
            {
                Console.WriteLine("在庫を入力してください:");
                input = Console.ReadLine();
            }

            if (stock == 0)
            {
                Console.WriteLine("在庫がありません");
            }
            else if (stock <= 3)
            {
                Console.WriteLine("在庫がわずかです");
            }
            else
            {
                Console.WriteLine("在庫があります");
            }
            Console.ReadLine();
        }
    }
}
