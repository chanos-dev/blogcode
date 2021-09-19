using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_0919
{
    class Program
    {
        static void Main(string[] args)
        {
            SingletonFoo.Instance.Foo();
            SingletonFoo.Instance.Boo();

            StaticFoo.Foo();            
        }
    } 

    internal abstract class BaseStatic
    {

    }

    internal interface IBase
    {

    }

    internal static class StaticFoo //: BaseStatic, IBase 상속 및 구현 불가능
    {
        internal static void Foo() => Console.WriteLine("스태틱~");
    }

    internal abstract class BaseSingleton
    {
        protected abstract string ClassName { get; set; }
    }

    internal class SingletonFoo : BaseSingleton
    {
        private readonly static SingletonFoo _instance;

        protected SingletonFoo() { }

        protected override string ClassName { get; set; } = nameof(SingletonFoo);

        static SingletonFoo()
        {
            _instance = new SingletonFoo();
        }

        internal static SingletonFoo Instance => _instance;

        internal void Foo() => Console.WriteLine("싱글벙글~");

        internal void Boo() => Console.WriteLine($"{ClassName}의 싱글벙글~");
    }
}
