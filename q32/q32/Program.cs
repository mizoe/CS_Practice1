﻿using System;
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

            foreach (var score in scores)
            {
                Console.WriteLine("氏名：{0} 点数:{1,3}",
                    score.Key,
                    score.Value
                );
            }
            Console.Read();
        }
    }
}
/*
氏名：矢吹 点数： 2
氏名：丹下 点数： 74
氏名：力石 点数： 80
氏名：白木 点数：100
氏名：西 点数： 10
 */
