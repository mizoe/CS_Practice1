using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q36
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            string input = "";
            var history = new List<int>();
            while (true)
            {
                //1以上6未満の乱数を整数で返す
                int dice = rand.Next(1, 7);
                history.Add(dice);
                Console.Write(dice + " ");
                input = Console.ReadLine();
            }
        }
    }
}
