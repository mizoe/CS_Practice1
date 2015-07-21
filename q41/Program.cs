using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q40
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            string input = "";
            var arrHistory = new List<int[]>();
            var history = new List<int>();
            int point = 1000;
            while (true)
            {
                //1以上6未満の乱数を整数で返す
                int[] dices = new int[3];
                for (int i = 0; i < 3; i++)
                {
                    dices[i] = rand.Next(1, 7);
                    history.Add(dices[i]);
                    Console.Write(dices[i] + " ");
                }
                arrHistory.Add(dices);
                //勝敗
                Array.Sort(dices);
                // 456
                if (dices[0] == 4 && dices[1] == 5 && dices[2] == 6)
                {
                    point += 1500;
                    Console.Write(" [456] +1500");
                }
                // ゾロ目
                else if (dices[0] == dices[1] && dices[1] == dices[2])
                {
                    point += 500;
                    Console.Write(" [ゾロ目] +500");
                }
                // 123
                else if (dices[0] == 1 && dices[1] == 2 && dices[2] == 3)
                {
                    point -= 100;
                    Console.Write(" [123] -100");
                }
                else
                {
                    point -= 50;
                }

                Console.Write(" point:" + point);
                input = Console.ReadLine();
                if (input == "h")
                {
                    Console.WriteLine("   --- HISTORY ---");
                    Console.Write("   ");
                    foreach (var h in history)
                    {
                        Console.Write(h + " ");
                    }
                    Console.WriteLine();
                    //履歴の統計情報
                    for (int i = 1; i <= 6; i++)
                    {
                        int freq = history.Where(c => c.Equals(i)).Count();
                        double ratio = freq / (double)history.Count * 100;
                        Console.WriteLine("   {0}: {1,4}回 確率{2,4}%", i, freq, ratio.ToString("F1"));
                    }
                    Console.WriteLine("   試行数:" + history.Count);
                    Console.WriteLine("   平均値:" + history.Average());
                }
            }
        }
    }
}


/*
(41)【サイコロその6】所持ポイントを次の条件で導入し、サイコロが振られるたびに
当たりハズレを判定し、その結果と所持ポイントを画面に表示させて下さい。
 初期状態で1,000 ポイント所持
 サイコロは3 個同時に振る
 プレイヤーが勝利のケース
     目が「456」の組み合わせの場合は250 ポイント取得
     ゾロ目（すべての目が同じ）の場合は150 ポイント取得
 プレイヤーが負けのケース
     「456」「ゾロ目」以外の場合はプレイヤーの負けとして50 ポイントを消費
     目が「123」の場合はペナルティとして50 ポイント加算され、上記の50 ポイ
ントとあわせて合計100 ポイントを消費
*/