using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aa
{
    class Wrapper
    {
        public static int GetInt(string s)
        {
            int result = 0;
            do
            {
                try
                {
                    Console.Write(s);
                    result = int.Parse(Console.ReadLine());
                    return result;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Nhap so nguyen");
                }

            } while (true);
        }

        public static double GetDouble(string s)
        {
            double result = 0;
            do
            {
                try
                {
                    Console.Write(s);
                    result = double.Parse(Console.ReadLine());
                    return result;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Nhap so thuc");
                }
            } while (true);
        }

        public static string GetString(string s)
        {
            string result = "";
            do
            {
                try
                {
                    Console.Write(s);
                    result = Console.ReadLine();
                    return result;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Nhap kieu chuoi");
                }
            } while (true);
        }

        public static DateTime GetDate(string s)
        {
            DateTime date = DateTime.Now;
            while (true)
            {
                try
                {
                    Console.Write(s);
                    date = DateTime.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Nhap kieu yyyy/mm/dd");
                }
            }
            return date;
        }
    }

}
