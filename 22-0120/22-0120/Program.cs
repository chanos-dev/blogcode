using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_0120
{
    class Program
    {
        static void CompareString(string foo)
        {
            string[] strs = new string[10000];

            Console.WriteLine("Without intern");
            foreach (var i in Enumerable.Range(1, 10000))
            {
                strs[i - 1] = $"{foo}!";
            }
            Console.WriteLine(GC.GetTotalMemory(true));
        }

        static void CompareStringWithIntern(string foo)
        {
            string[] strs = new string[10000];

            Console.WriteLine("With intern");
            string.Intern($"{foo}!");

            foreach (var i in Enumerable.Range(1, 10000))
            {
                strs[i - 1] = string.IsInterned($"{foo}!");
            }
            Console.WriteLine(GC.GetTotalMemory(true));
        }

        static void Main(string[] args)
        {
            //string s1 = "hello, world";
            //string s2 = string.Concat("hello, ", "world");
            //string s3 = string.Format("{0}, {1}", "hello", "world"); // 보간법도 동일합니다.
            //string s4 = new StringBuilder("hello, world").ToString();
            //string s5 = "hello, world";

            //Console.WriteLine($"equals : {s1.Equals(s2)} / reference equals {object.ReferenceEquals(s1, s2)}");
            //Console.WriteLine($"equals : {s1.Equals(s3)} / reference equals {object.ReferenceEquals(s1, s3)}");
            //Console.WriteLine($"equals : {s1.Equals(s4)} / reference equals {object.ReferenceEquals(s1, s4)}");
            //Console.WriteLine($"equals : {s1.Equals(s5)} / reference equals {object.ReferenceEquals(s1, s5)}");

            string s1 = "hello, world";
            string s2 = string.Intern(string.Concat("hello, ", "world"));
            string s3 = string.Concat("hello, ", "world");
            string s4 = string.Format("{0}, {1}", "hello", "world");
            string s5 = new StringBuilder("hello, world").ToString();
            string s6 = string.IsInterned("Hello, csharp!");

            Console.WriteLine($"equals : {s1.Equals(s2)} / reference equals {object.ReferenceEquals(s1, s2)}");
            Console.WriteLine($"equals : {s1.Equals(s3)} / reference equals {object.ReferenceEquals(s1, s3)}");
            Console.WriteLine($"equals : {s1.Equals(s4)} / reference equals {object.ReferenceEquals(s1, s4)}");
            Console.WriteLine($"equals : {s1.Equals(s5)} / reference equals {object.ReferenceEquals(s1, s5)}");
            Console.WriteLine($"equals : {s1.Equals(s6)} / reference equals {object.ReferenceEquals(s1, s6)}");

            string foo = "hello, world";
            string weak = string.Concat("hello,", " world");

            CompareString(foo);
            CompareStringWithIntern(foo);

            WeakReference w1 = new WeakReference(foo);
            WeakReference w2 = new WeakReference(weak);

            foo = null;
            weak = null;
            GC.Collect();

            Console.WriteLine($"foo is alive ? {w1.IsAlive}");
            Console.WriteLine($"weak is alive ? {w2.IsAlive}");
            Console.WriteLine(string.IsInterned("hello, world")); 
        }
    }
}
