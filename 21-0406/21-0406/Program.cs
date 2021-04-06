using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_0406
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new { Name = "홍길동", Age = 24, Address = "경기도 광주" };
            // person.Address = "경기도 성남시"; 할당 불가능.             

            // person 인스턴스와 서로 다른 익명 타입
            var person2 = new { Name = "홍길동", Address = "경기도 광주", Age = 24 };

            var cities = new[]
            {
                new { Name = "Baek", Age = 50, Job = "Programmer"},
                new { Name = "Lee", Age = 20, Job = "Chef"},
                new { Name = "Park", Age = 30, Job = "Teacher"},
                new { Name = "Choi", Age = 40, Job = "Docter"},
            };

            var lists = cities.Where(c => c.Age <= 30).Select(c => new { c.Name, c.Job });

            foreach(var list in lists)
            {
                Console.WriteLine($"{list.Name} is {list.Job}");
            }
        }
    }
}
