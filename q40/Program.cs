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
            var history    = new List<int>();
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
                        Console.WriteLine("   {0}: {1,4}回 確率{2,4}%",
                            i, freq, ratio.ToString("F1"));
                    }
                    Console.WriteLine("   試行数:" + history.Count);
                    Console.WriteLine("   平均値:" + history.Average());
                }
            }
        }
    }
}


/*
(38) 【サイコロその3】(37)の履歴の統計情報を出力するように変更して下さい。
出力する統計情報は、サイの目のそれぞれの出現数と出現確率、試行数、平均値としま
す。
*/

/*
【サイコロその4】(36)のサイの目が3 個同時に表示されるように変更して下さ
い。

【サイコロその5】(39)の履歴が3 個分保存され、(38)と同様に表示されるように
変更して下さい。
*/