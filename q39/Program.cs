using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q38
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            string input = "";
            while (true)
            {
                //1以上6未満の乱数を整数で返す
                int[] dices = new int[3];
                for (int i = 0; i < 3; i++)
                {
                    dices[i] = rand.Next(1, 7);
                    Console.Write(dices[i] + " ");
                }
                input = Console.ReadLine();
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