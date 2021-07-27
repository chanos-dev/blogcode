using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_0726
{
    class Program
    {
        static void Main(string[] args)
        {
            Parent child = new Child();
            Compare(child);
        }

        private static void Compare(Parent obj)
        {
            Parent newChild = new Child();
            // false
            Console.WriteLine(obj.GetType() == typeof(Parent));
            // true
            Console.WriteLine(obj.GetType() == typeof(Child));
            // true
            Console.WriteLine(obj.GetType() == newChild.GetType());
        }
    }

    class Parent { }

    class Child : Parent { }
}
