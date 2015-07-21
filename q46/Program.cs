using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q46
{
    class Program
    {
        static void Main(string[] args)
        {
            var p3 = new Person("人間", "太郎", "にんげん", "たろう", new DateTime(1970, 1, 1));
            var scores = new Dictionary<string, int>
            {
                { "社会", 100 },
                { "数学", 80 }
            };
            var s2 = new Student("学生", "次郎", "がくせい", "じろう", new DateTime(1970, 1, 1),
                scores);

            Console.Write(p3.lastName + " " + p3.firstName);
            Console.WriteLine(s2.lastName + " " + "合計点:" + s2.getTotal());
        }
    }
}
