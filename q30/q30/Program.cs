using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q30
{
    class Program
    {
        static void Main(string[] args)
        {
            var stocks = new Dictionary<string, int>();
            stocks["やくそう"]       = 50;
            stocks["どくけしそう"]   = 20;
            stocks["せかいじゅのは"] = 1;
            stocks["せいすい"]       = 3;

            foreach (var stock in stocks)
            {
                Console.WriteLine(stock.Key + "\t{0,2}個", stock.Value);
            }
            Console.Read();
        }
    }
}
