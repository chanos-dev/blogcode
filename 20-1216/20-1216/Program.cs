using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_1216
{
    class Program
    {
        static Stopwatch stopwatch = new Stopwatch();
        
        static void Main(string[] args)
        {
            int a;
            int b;
            int temp;

            stopwatch.Reset();
            a = 10;
            b = 20;

            stopwatch.Start();
            for (int i = 0; i < 100000001; i++)
            {
                temp = a;
                a = b;
                b = temp;
            }
            stopwatch.Stop();
            Console.WriteLine($"temp : {a}, {b}");
            Console.WriteLine(stopwatch.Elapsed);

            stopwatch.Reset();
            a = 10;
            b = 20;

            stopwatch.Start();
            for (int i = 0; i < 100000001; i++)
            {
                a ^= b ^= a;
                b ^= a;
            }
            stopwatch.Stop();
            Console.WriteLine($"xor : {a}, {b}");
            Console.WriteLine(stopwatch.Elapsed);

            stopwatch.Reset();
            a = 10;
            b = 20;

            stopwatch.Start();
            for (int i = 0; i < 100000001; i++)
            {
                a += b;  
                b = a - b;  
                a -= b;
            }
            stopwatch.Stop();
            Console.WriteLine($"add, sub : {a}, {b}");
            Console.WriteLine(stopwatch.Elapsed);
        }
    }
}
