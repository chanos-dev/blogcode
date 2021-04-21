using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_0421
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person()
            {
                Name = "백찬호",
                Age = 24,
                Job = "Programmer",
            };

            Console.WriteLine(person);

            var (name, age, job) = person;

            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(job);

            var (name2, age2) = person;

            Console.WriteLine(name2);
            Console.WriteLine(age2); 
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Job { get; set; }

        public Person()
        {

        } 

        public void Deconstruct(out string Name)
        {
            Name = this.Name;
        }

        public void Deconstruct(out string Name, out int Age)
        {
            Name = this.Name;
            Age = this.Age; 
        }

        public void Deconstruct(out string Name, out int Age, out string Job)
        {
            Name = this.Name;
            Age = this.Age;
            Job = this.Job;
        }

        public override string ToString() => $"Name : {Name}\nAge : {Age}\nJob : {Job}";
    }
}
