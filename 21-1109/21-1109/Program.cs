using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace _21_1109
{
    class Program
    {
        static void Main(string[] args)
        {
            var foo = new Foo()
            {
                Value = "Hello, World",
            };

            var binaryFormatter = new BinaryFormatter();

            using (var stream = File.Open("hello.txt", FileMode.Create))
            {
                binaryFormatter.Serialize(stream, foo);
                Console.WriteLine(foo.Value);
            }

            using (var stream = File.Open("hello.txt", FileMode.Open))
            {
                var newFoo = binaryFormatter.Deserialize(stream) as Foo;
                Console.WriteLine(newFoo.Value);
            }

            using (var ms = new MemoryStream())
            {
                binaryFormatter.Serialize(ms, foo);

                Console.WriteLine(Encoding.UTF8.GetString(ms.ToArray()));
            }
        }
    }

    [Serializable]
    internal class Foo
    {
        internal string Value { get; set; }
    }
}
