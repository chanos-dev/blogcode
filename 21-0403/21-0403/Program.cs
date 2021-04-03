using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_0403
{
    class Program
    {
        static void Main(string[] args)
        {
            var time = new Time()
            {
                Hour = 5,
                Minute = 30,
                Second = 15,
            };

            int totalSec = time;

            Console.WriteLine($"Sec : {totalSec}");

            var meter = new Meter(5.5f);

            Console.WriteLine(meter);

            var centimeter = (Centimeter)meter;

            Console.WriteLine(centimeter);  
        }
    }

    class Time
    {
        public int Hour { get; set; }

        public int Minute { get; set; }

        public int Second { get; set; }

        public static implicit operator int(Time time) => time.Hour * 3600 + time.Minute * 60 + time.Second;
    }

    class Meter
    {
        public float M { get; set; }

        public Meter(float m) => M = m;

        public static implicit operator string(Meter m) => $"{m.M}m";

        public static explicit operator Centimeter(Meter m) => new Centimeter(m.M * 100);
    }

    class Centimeter
    {
        public float Cm { get; set; }

        public Centimeter(float cm) => Cm = cm;

        public static implicit operator string(Centimeter c) => $"{c.Cm}cm";

        public static explicit operator Meter(Centimeter c) => new Meter(c.Cm / 100);
    } 
}
