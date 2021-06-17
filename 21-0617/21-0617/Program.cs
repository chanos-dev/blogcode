using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_0617
{
    class Program
    {
        static void Main(string[] args)
        {
            var originFoos = new List<Foo>()
            {
                new Foo("1.origin"),
                new Foo("2.origin"),
                new Foo("3.origin"),
                new Foo("4.origin"),
                new Foo("5.origin"),
            };

            var newFoos = originFoos.ToList();

            Console.WriteLine(originFoos.Equals(newFoos));
            Console.WriteLine(originFoos[0].Equals(newFoos[0]));

            Console.WriteLine("--- originFoos ---");
            foreach (var foo in originFoos)
            {
                Console.WriteLine(foo.Value);
            }
            Console.WriteLine("--- newFoos ---");
            foreach (var foo in newFoos)
            {
                Console.WriteLine(foo.Value);
            }

            originFoos[0].Value = "1.change";

            Console.WriteLine("--- originFoos ---");
            foreach (var foo in originFoos)
            {
                Console.WriteLine(foo.Value);
            }
            Console.WriteLine("--- newFoos ---");
            foreach (var foo in newFoos)
            {
                Console.WriteLine(foo.Value);
            }
        }
    }

    class Foo
    {
        public string Value { get; set; }

        public Foo(string val)
        {
            this.Value = val;
        }
    }
}
