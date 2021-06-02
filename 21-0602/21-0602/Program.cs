using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_0602
{
    class Program
    {
        static void Main(string[] args)
        {
            var animals = new List<Animal>()
            {
                new Animal("Tiger", 5),
                new Animal("Lion", 8),
                new Animal("Tiger", 6),
                new Animal("Tiger", 4),
            };

            var tiger = new Animal("Tiger", 5);

            Console.WriteLine($"Same Animal count : {GetSameObejct(tiger, animals)}");

            var persons = new List<Person>()
            {
                new Person("Json", 5),
                new Person("Mika", 8),
                new Person("Mika", 6),
                new Person("Json", 4),
            };

            var person = persons[0];

            // 컴파일러 에러 : CS0311
            Console.WriteLine($"Same Animal count : {GetSameObejct(person, persons)}");
        }

        private static int GetSameObejct<T>(T target, List<T> animals)
            where T : IEquatable<T>
        {            
            return animals.Where(animal => target.Equals(animal)).Count();
        }
    }
     
    class Animal : IEquatable<Animal>
    { 
        public string Name { get; set; }
        public int Age { get; set; }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public bool Equals(Animal other)
        {
            if (other is null)
                return false;

            if (ReferenceEquals(this, other))
                return true;

            return this.Name == other.Name;
        }

        public override bool Equals(object obj) => this.Equals(obj as Animal);

        public override int GetHashCode()
        {
            return 539060726 + EqualityComparer<string>.Default.GetHashCode(Name);
        }

        public static bool operator ==(Animal left, Animal right)
        {
            if (left is null)
            {
                if (right is null)
                    return true;

                return false;
            }

            return left.Equals(right);
        }

        public static bool operator !=(Animal left, Animal right) => !(left == right);
    }

    class Person 
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
