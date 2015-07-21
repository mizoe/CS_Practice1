using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q42
{
    class Person
    {
        //フィールド
        public string lastName; //姓
        public string firstName; //名
        public string furiganaLastName; //姓ふりがな
        public string furiganaFirstName; //名ふりがな
        public DateTime birthday; //誕生日

        //メソッド
        public int getAge()
        {
            int age = 0;
            DateTime now = new DateTime();//現在
            //参考：http://dobon.net/vb/dotnet/system/getage.html
            age = now.Year - birthday.Year;
            //誕生日前だったら
            if (now.Month < birthday.Month || 
                (now.Month == birthday.Month && now.Day < birthday.Day))
            {
                age--;
            }
            return age;
        }
    }
}
