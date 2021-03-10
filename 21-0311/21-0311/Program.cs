using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_0311
{
    class Program
    {
        static void Main(string[] args)
        {
            var properties = typeof(Person).GetProperties();

            foreach (var property in properties)
            {
                Console.WriteLine(property.Name);
            }

            Console.WriteLine("");

            var skipProperties = typeof(Person).GetProperties().Where(property => !Attribute.IsDefined(property, typeof(SkipPropertyAttribute)));

            foreach (var skip in skipProperties)
            {
                Console.WriteLine(skip.Name);
            }
        }
    }

    class SkipPropertyAttribute : Attribute
    {

    }

    class Person
    {
        [SkipProperty]
        public string PersonalID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; } 
        public string Address { get; set; } 
    }
}
