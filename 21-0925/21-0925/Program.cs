using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_0925
{
    internal enum FooType
    {
        foo1,
        foo2,
        foo3,
    }

    internal enum BooType
    {
        boo1,
        boo2,
        boo3,
    }

    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();

            Console.WriteLine(string.Join(", ", p.GenericFoo<FooType>()));
            Console.WriteLine(string.Join(", ", p.GenericFoo<BooType>()));

            var enumType = typeof(BooType);
            // Console.WriteLine(string.Join(", ", p.GenericFoo<type>())); // error

            var programType = p.GetType();
            // instance method
            var genericValues = programType.GetMethod(nameof(Program.GenericFoo)).MakeGenericMethod(enumType).Invoke(p, null) as string[];
            Console.WriteLine(string.Join(", ", genericValues));

            enumType = typeof(FooType);
            // class method
            genericValues = typeof(Program).GetMethod(nameof(Program.GenericBoo)).MakeGenericMethod(enumType).Invoke(null, null) as string[];
            Console.WriteLine(string.Join(", ", genericValues));

            programType.GetMethod(nameof(Program.TwoGenericFoo)).MakeGenericMethod(enumType, typeof(int)).Invoke(p, new object[] { "test value" });
        }

        public string[] GenericFoo<TEnum>()
            where TEnum : Enum
        {
            return Enum.GetNames(typeof(TEnum));
        }

        public static string[] GenericBoo<TEnum>()
            where TEnum : Enum
        {
            return Enum.GetNames(typeof(TEnum));
        }

        public void TwoGenericFoo<T, U>(string value)
            where T : Enum
            where U : struct
        {
            Console.WriteLine($"type of T is {typeof(T).Name}");
            Console.WriteLine($"type of U is {typeof(U).Name}");
            Console.WriteLine($"Call TwoGenericFoo Method!! : {value}");
        }
    }
}