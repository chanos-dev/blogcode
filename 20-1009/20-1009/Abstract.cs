using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_1009
{ 
    abstract class Animal
    {
        protected string Name;
        protected string Type;

        public abstract void Run();
        public abstract void Fly();
        public abstract void Sound();

        public void GetInfo()
        {
            Console.WriteLine($"너의 이름은 {Name}, 종류는 {Type}!!");
        }
    }

    class Dog : Animal
    {
        public Dog(string name, string type)
        {
            Name = name;
            Type = type;
        }

        public override void Fly()
        {
            Console.WriteLine("멍멍~! 못날아요~!");
        }

        public override void Run()
        {
            Console.WriteLine("주인님 한테 달려가아~!");
        }

        public override void Sound()
        {
            Console.WriteLine("멍멍!");
        }


    }

    class Cat : Animal
    {
        public Cat(string name, string type)
        {
            Name = name;
            Type = type;
        }

        public override void Fly()
        {
            Console.WriteLine("냐옹~! 못날아요~!");
        }

        public override void Run()
        {
            Console.WriteLine("상자 속으로 달려가아~!");
        }

        public override void Sound()
        {
            Console.WriteLine("냐옹!");
        }
    }

    class Pigeon : Animal
    {
        public Pigeon(string name, string type)
        {
            Name = name;
            Type = type;
        }

        public override void Fly()
        {
            Console.WriteLine("하늘 위로..!!");
        }

        public override void Run()
        {
            Console.WriteLine("구구~! 못달려요~!");
        }

        public override void Sound()
        {
            Console.WriteLine("구구!");
        }
    } 
} 
