using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q07
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rooms = { "101", "102", "103" };
            int[] area = { 100, 75, 150 };
            double oneTsubo = 3.3;
            for (int i = 0; i < rooms.Length; i++)
            {
                Console.WriteLine
                    ("{0}号室 {1,3}平方メートル({2,5}坪)",
                        rooms[i],
                        area[i],
                       (area[i] / oneTsubo).ToString("F2")
                    );
            }
            Console.ReadLine();
        }
    }
}
