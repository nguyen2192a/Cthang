using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo01
{
    class StudentDAO
    {
        List<Student> list = null;
        public StudentDAO() {
           list = new List<Student>();
        
        }
        public Student Create(Student s)
        {
            list.Add(s);
            return s;
        }
        public List<Student> ReadAll()
        {
            return list;
        }
        public Student Update(Student s)
        {
            foreach (Student ss in list)
            {
                if (ss.id == s.id)
                {
                    ss.name = s.name;
                    ss.age = s.age;
                }
            }
            return s;
        }
        public Boolean Delete(int id)
        {
            foreach (Student ss in list)
            {
                if (ss.id == id)
                {
                    list.Remove(ss);
                    return true;
                }
            }
            return false;
        }
        public Student SearchByid(int id)
        {
            foreach(Student s in list)
            {
                if(s.id == id)
                {
                    return s;
                }
            }
            return null;
        }
    }
}
