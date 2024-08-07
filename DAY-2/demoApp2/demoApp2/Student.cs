using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoApp2
{
    internal class Student
    {
        public int studentId;
        public string studentName;
        public int marks;
        private int _age;
        public static string collegeName;

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if(value>=18 && value <= 60)
                {
                    _age=value;
                }
            }
        }
    }
}
