using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string result = GetFullName("Afiq", "Mehdizade",19);
            Print(result);
        }

        public static string GetFullName(string name, string surName)
        {
            string fullName = name + " " + surName;
            return fullName;
        }

        public static string GetFullName(string name, string surName, int age)
        {
            if (age > 18)
            {
                string result = name + " " + surName + " olar";
                return result;
            }
            else
            {
                string result = name + " " + surName + " olmaz";
                return result;
            }

        }
        public static void Print(string data)
        {
            Console.WriteLine(data);
        }
    }
}
