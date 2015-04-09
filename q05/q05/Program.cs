using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q05
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lastNames  = { "Suzuki", "Tanaka", "Kimura", "Shima" };
            string[] firstNames = { "Taro", "Hanako", "Jiro", "Tetsuo" };
            int i = 0;
            foreach (var lastName in lastNames)
            {
                Console.WriteLine(lastName + " " + firstNames[i]);
                i++;
            }
            Console.WriteLine("終了するにはENTERキーを押してください。");
            Console.ReadLine();
        }
    }
}
