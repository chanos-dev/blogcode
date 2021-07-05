using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_0705
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{DateTime.Now}");
            Console.WriteLine($"{DateTime.Now:d}");

            Console.WriteLine("");

            var calc = new Calc(100, 50);

            Console.WriteLine($"{calc}");
            Console.WriteLine($"{calc:+}");
            Console.WriteLine($"{calc:-}");
            Console.WriteLine($"{calc:*}");
            Console.WriteLine($"{calc:/}");
        }
    }

    class Calc : IFormattable
    {       
        public int n1 { get; set; }
        public int n2 { get; set; }

        public Calc(int n1, int n2)
        {
            this.n1 = n1;
            this.n2 = n2;
        }

        public override string ToString() => ToString(string.Empty, CultureInfo.CurrentCulture);

        public string ToString(string format, IFormatProvider formatProvider)
        {
            if (string.IsNullOrEmpty(format))
                format = "None";

            if (formatProvider is null)
                formatProvider = CultureInfo.CurrentCulture;

            switch (format)
            {
                case "None":
                    return $"n1 : {n1}, n2 : {n2}";
                case "+":
                    return $"n1 + n2 : {n1 + n2}";
                case "-":
                    return $"n1 - n2 : {n1 - n2}";
                case "*":
                    return $"n1 * n2 : {n1 * n2}";
                case "/":
                    return $"n1 / n2 : {n1 / n2}";
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
