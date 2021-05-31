using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_0531
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "World!";
            string b = "World!";
            string c = "Hello, World!".Substring(7);
            object d = c;

            Console.WriteLine($"a == b : {a == b}");
            Console.WriteLine($"a.Equals(b) : {a.Equals(b)}");
            Console.WriteLine("");

            Console.WriteLine($"a == c : {a == c}");
            Console.WriteLine($"a.Equals(c) : {a.Equals(c)}");
            Console.WriteLine("");

            Console.WriteLine($"a == d : {a == d}");
            Console.WriteLine($"a.Equals(d) : {a.Equals(d)}");
            Console.WriteLine("");

            CheckStringVariable(a, b);
            CheckStringVariable(a, c);
        }

        static void CheckStringVariable<T>(T o, T t)
            where T : class
        {
            Console.WriteLine($"o == t : {o == t}");
            Console.WriteLine($"o.Equals(t) : {o.Equals(t)}");
        }
    }
}
