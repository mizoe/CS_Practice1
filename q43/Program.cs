using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q43
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Person();
            p1.lastName         = "田中";
            p1.firstName        = "太郎";
            p1.furiganaLastName = "たなか";
            p1.furiganaLastName = "たろう";
            p1.birthday         = new DateTime(2009,1,1);

            var p2 = new Person();
            p2.lastName = "鈴木";
            p2.firstName = "花子";
            p2.furiganaLastName = "すずき";
            p2.furiganaLastName = "はなこ";
            p2.birthday = new DateTime(2008,12,31);

            Console.WriteLine(p1.lastName + " " + p1.getAge());
            Console.WriteLine(p2.lastName + " " + p2.getAge());
        }
    }
}
