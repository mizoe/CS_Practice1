using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q32
{
    class Program
    {
        static void Main(string[] args)
        {
            var scores = new Dictionary<string, int>();
            scores["矢吹"] = 2;
            scores["丹下"] = 74;
            scores["力石"] = 80;
            scores["白木"] = 100;
            scores["西  "] = 10;

            int sum = 0;
            foreach (var score in scores)
            {
                Console.Write("氏名：{0} 点数:{1,3} ",
                    score.Key,
                    score.Value
                );
                sum += score.Value;
                if (score.Value >= 80)
                {
                    Console.WriteLine("評価：優");
                }
                else if (score.Value >= 70)
                {
                    Console.WriteLine("評価：良");
                }
                else if (score.Value >= 60)
                {
                    Console.WriteLine("評価：可");
                }
                else
                {
                    Console.WriteLine("評価：不可");
                }

            }
            Console.WriteLine("受験者 " + scores.Count + "名");
            Console.WriteLine("合計点 " + sum + "点");
            Console.WriteLine("平均点 " + (int)(sum / scores.Count) + "点");
            Console.Read();
        }
    }
}
/*
(32) の配列を利用して、次の基準で判定し、判定結果を出力してください。

８０点以上 →優
７０点～７９点→良
６０点～６９点→可
６０点未満 →不可
氏名：矢吹 点数： 2 評価：不可
氏名：丹下 点数： 74 評価：良
氏名：力石 点数： 80 評価：優
氏名：白木 点数：100 評価：優
氏名：西 点数： 10 評価：不可

 */
