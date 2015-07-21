using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q44
{
    // Javaと違って独立したcsファイルでなくてもOK（この内容を Person.cs に書いても良い）
    class Student : Person 
    {
        public string id;
        public int grade;
        public Dictionary<string, int> scores;

        public int getTotal()
        {
            return scores.Values.Sum();
        }
    }
}
