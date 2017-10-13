using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo01
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentDAO dao = new StudentDAO();

            do
            {
                Console.WriteLine("Nhap 1: add");
                Console.WriteLine("Nhap 2: read");
                Console.WriteLine("Nhap 3: update");
                Console.WriteLine("Nhap 4: delete");
                Console.WriteLine("Nhap 5: search");
                Console.WriteLine("Nhap 6: exit");
                Console.WriteLine("Nhap lua chon: ");
                int choose = Convert.ToInt32(Console.ReadLine());
                int id, age;
                string name;
                switch (choose)
                {
                    case 1:
                        Console.WriteLine("id");
                        id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("age");
                        age = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("name");
                        name = Console.ReadLine();
                        Student s = new demo01.Student(id, name, age);
                        dao.Create(s);
                        break;
                    case 2:
                        List<Student> l = dao.ReadAll();
                        foreach (Student ss in l)
                        {
                            Console.WriteLine("Name: " + ss.name);
                        }
                        break;
                    case 3:
                        Console.WriteLine("id");
                        id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("age");
                        age = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("name");
                        name = Console.ReadLine();
                        s = new demo01.Student(id, name, age);
                        dao.Update(s);
                        break;
                    case 4:
                        Console.WriteLine("id");
                        id = Convert.ToInt32(Console.ReadLine());

                        if (dao.Delete(id) == true)
                        {
                            Console.WriteLine("Success");
                        }
                        else
                        {
                            Console.WriteLine("Fail");

                        }
                        break;
                    case 5:
                        Console.WriteLine("id");
                        id = Convert.ToInt32(Console.ReadLine());
                        if (dao.SearchByid(id) != null)
                        {
                            Console.WriteLine("Name: " + dao.SearchByid(id).name);
                        }
                        else
                        {
                            Console.WriteLine("Fail");

                        }
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Nhap tu 1 den 6");
                        break;
                }
            } while (true);
        }
    }
}
