using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("在庫を入力してください:");
            string input = Console.ReadLine();
            int stock = int.Parse(input);

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
