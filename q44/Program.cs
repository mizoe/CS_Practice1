using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q44
{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = new Student();
            s1.lastName = "田中";
            s1.firstName = "太郎";
            s1.furiganaLastName = "たなか";
            s1.furiganaLastName = "たろう";
            s1.birthday = new DateTime(2009, 1, 1);
            s1.scores = new Dictionary<string, int>();
            s1.scores["国語"] = 100;
            s1.scores["数学"] = 99;
            Console.WriteLine(s1.getTotal());
        }
    }
}
