using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q46
{
    class Person
    {
        //フィールド
        public string lastName; //姓
        public string firstName; //名
        public string furiganaLastName; //姓ふりがな
        public string furiganaFirstName; //名ふりがな
        public DateTime birthday; //誕生日

        public uint height { get; set; } //負にしないため unit
        public uint weight { get; set; }

        //コンストラクタ
        public Person()
        {
        }

        public Person(string lastName, string firstName, string furiganaLastName,
            string furiganaFirstName, DateTime birthday)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.furiganaLastName = furiganaLastName;
            this.furiganaFirstName = furiganaFirstName;
            this.birthday = birthday;
        }

        //メソッド
        public int getAge()
        {
            int age = 0;
            DateTime now = DateTime.Now;//現在
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

    // Student.csからお引越し
    //（問題46にはないですが、子クラスのコンストラクタをどう記載するかの参考のため）
    class Student : Person
    {
        public string id;
        public int grade;
        public Dictionary<string, int> scores;

        public Student() { }

        // 子クラスのコンストラクタ。「: base」が重要です。Personのときより引数が増えてる
        public Student(string lastName, string firstName, string furiganaLastName,
            string furiganaFirstName, DateTime birthday, 
            Dictionary<string, int> scores)
            : base(lastName, firstName, furiganaLastName,
             furiganaFirstName, birthday)
        {
            this.scores = scores;
        }

        public int getTotal()
        {
            return scores.Values.Sum();
        }
    }
}
