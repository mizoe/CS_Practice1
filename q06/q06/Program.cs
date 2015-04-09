using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q06
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] places = { "青森→東京　", "飯田橋→渋谷", "飯田橋→横浜" };
            double[] distances = { 715.0, 6.9, 33.8 };
            double oneMile = 1.609344;
            for (int i = 0; i < places.Length; i++)
            {
                Console.WriteLine
                    ("{0} {1,6}km({2,6}マイル)",
                        places[i],
                        distances[i].ToString("F1"),
                       (distances[i] / oneMile).ToString("F2")
                    );
            }
            Console.ReadLine();
        }
    }
}
