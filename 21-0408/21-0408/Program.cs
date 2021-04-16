using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_0408
{
    interface ITest
    {
        string hello { get; } 
    }

    class Program
    {
        private readonly Person person;// = new Person("홍길동", 24);
        private static readonly Person person2 = new Person("심봉사", 24);
        private const float Pi = 3.14f;

        static void Main(string[] args)
        {
            var a = new Program(); 
        }

        public Program()
        {
            person = new Person("홍길동", 24);
            // Pi = 3.1415f; (X)
            // person2 = null; ( X )
        }

        static Program()
        {
            person2 = null;
        }
    }

    class Person : ITest
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public string hello { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    } 
}
