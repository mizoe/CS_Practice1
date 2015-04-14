using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q35
{
    class Program
    {
        static void Main(string[] args)
        {
            var dows = new string[] { "日曜日", "月曜日", "火曜日", "水曜日", "木曜日", "金曜日", "土曜日" };
            int num;
            string input = "";
            Console.WriteLine("0～6 の数字を入力してください。対応した曜日を表示します。");
            while (int.TryParse(input, out num) == false || (num < 0 || num > 6))
            {
                if ((num < 0 || num > 6))
                {
                    Console.WriteLine("0～6 の範囲で入力してください");
                }
                else
                {
                    Console.WriteLine("数字を入力してください");
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(dows[num]);
            Console.Read();
        }
    }
}

/*
(35) まず、
0～6 の数字を入力してください。対応した曜日を表示します。
と画面に表示し、キーボードから0～6 の数字を入力すると、その数字に応じて次のよ
うに対応する曜日を表示して終了するプログラムを作ってください。対応する曜日を求
める際は switch 文を使うこと。
0 日曜日、1 月曜日、…、6 土曜日
なお、0～6 以外の数字の入力があった場合には
0～6 の範囲で入力してください
と表示して最初に戻り、数字以外の入力があった場合には
数字を入力してください
と表示して最初に戻るようにして下さい。

 */
