using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_0104
{
    static class ExtensionClass
    {
        public static int Factorial(this int i)
        {
            if (i < 2)
                return 1;
            else
                return i * Factorial(i - 1);
        }

        public static string StringConcat(this string str, string str2)
        {
            return str + str2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int inumber;
            Console.Write("Factorial : ");
            if (int.TryParse(Console.ReadLine(), out inumber))
                Console.WriteLine(inumber.Factorial().ToString());
            else
                Console.WriteLine("Input Error"); 

            string str = "Hello";
            Console.WriteLine(str.StringConcat(" World"));  
        }
    }
}
