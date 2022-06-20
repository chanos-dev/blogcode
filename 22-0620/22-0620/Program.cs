using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_0620
{
    class Program
    {
        static void Main(string[] args)
        {
            Capacity();
            NonCapacity();
        }

        private static void Capacity()
        {
            List<int> list = new List<int>(1 << 26);
            list.AddRange(Enumerable.Range(1, 1 << 26));
            Console.WriteLine($"capacity : {list.Capacity}, count : {list.Count}");
            list.Add(-1);
            Console.WriteLine($"capacity : {list.Capacity}, count : {list.Count}");
        }

        private static void NonCapacity()
        {
            List<int> list = new List<int>();
            list.AddRange(Enumerable.Range(1, 1 << 26));
            Console.WriteLine($"capacity : {list.Capacity}, count : {list.Count}");
            list.Add(-1);
            Console.WriteLine($"capacity : {list.Capacity}, count : {list.Count}");
        }
    }
}
