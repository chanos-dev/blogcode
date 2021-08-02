using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_0802
{
    class Program
    {
        static void Main(string[] args)
        {
            var foo = new Foo();

        }
    }

    class Foo
    {
        private StreamWriter sw { get; set; }

        public Foo()
        {
            sw = new StreamWriter(@"C:\Users\Chanos\Desktop\git\test.txt");
        }

        ~Foo()
        {
            sw?.Close();
        }
    }

}
