using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace MotobikeStore
{
    public class Wrappers
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
                    Console.WriteLine(ex.Message);
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
                    Console.WriteLine(ex.Message);
                }
            } while (true);
        }

        public static float GetFloat(string s)
        {
            float result = 0;
            do
            {
                try
                {
                    Console.Write(s);
                    result = float.Parse(Console.ReadLine());
                    return result;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
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
                    Console.WriteLine(ex.Message);
                }
            } while (true);
        }

        public static DateTime GetDateTime(string s)
        {
            DateTime date = DateTime.Now;
            while (true)
            {
                try
                {
                    date = DateTime.Parse(GetString(s));
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Correct format: yyyy/mm/dd");
                }
            }

            return date;
            
        }

        public static string GetEmail(string s)
        {
            Regex regex = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            string email = "";
            do
            {
                Console.Write(s);
                email = Console.ReadLine();

                Match match = regex.Match(email);
                if (match.Success)
                    break;
                else
                    Console.WriteLine("Email is not valid !");
            } while (true);

            return email;
        }

        
    }
}
