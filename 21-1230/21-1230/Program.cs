using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_1230
{
    struct Foo
    {
        public string Name;
        public int Age;

        public void IncAge()
        {
            this.Age++;
        }
    }

    class Program
    { 
        private readonly Foo ReadOnlyFoo = new Foo { Age = 30, Name = "홍길동" };
        private Foo NormalFoo = new Foo { Age = 24, Name = "심청이" };
        static void Main(string[] args)
        {
            var p = new Program();

            // p.NormalFoo.Age++;
            // p.ReadOnlyFoo.Age++; // Compiler Error CS1648 !!

            p.NormalFoo.IncAge(); 
            p.ReadOnlyFoo.IncAge();

            // 25
            Console.WriteLine(p.NormalFoo.Age);
            // 30
            Console.WriteLine(p.ReadOnlyFoo.Age); 
        }
    }
}
