using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo01
{
    class Student
    {
        public Student() { }
        public string name { get; set; }
        public int age { get; set; }
        public int id { get; set; }
        public Student(int id, String name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }
    }
}
