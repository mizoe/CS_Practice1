using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q31
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] products = new int[3, 4] {
                {1, 99, 100, 50},
                {2, 200, 5000, 3000},
                {3, 50, 90, 33}
            };
            Console.WriteLine("商品番号    在庫 販売価格 仕入価格");
            Console.WriteLine("----------------------------------");
            int i = 0;
            foreach (var p in products)
            {
                if (i == 4)
                {
                    i = 0;
                    Console.WriteLine();
                }
                Console.Write("{0,8}", p);
                i++;
            }
            Console.Read();
        }
    }
}
/*
 * (31) 商品番号・在庫・販売価格・仕入価格を整数で表す多次元配列を定義し、次のよう
に画面に表示してください。
 * 
商品番号 在庫 販売価格 仕入価格
----------------------------------
1 99 100 50
2 200 5000 3000
3 50 90 33
*/