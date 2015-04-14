using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("          生まれたばかり 生後1ヶ月 生後2ヶ月以降 つがいの数");
            int p0 = 1, p1 = 0, p2 = 0, pn = 0;
            for (int i = 0; i <= 24; i++)
            {
                pn = p0 + p1 + p2;
                Console.WriteLine("{0,2}ヶ月後       {1,5}       {2,5}      {3,5}      {4,5}", i, p0, p1, p2, pn);
                int lastP0 = p0;
                int lastP1 = p1;
                int lastP2 = p2;
                p0 = lastP1 + lastP2;
                p1 = lastP0;
                p2 = lastP1 + lastP2;
            }
            Console.Read();
        }
    }
}
