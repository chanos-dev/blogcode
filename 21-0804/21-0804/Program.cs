using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_0804
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var foo1 = new Foo(Image.FromFile(@"C:\test.jpg")))
            {
                foo1.Name = "Foo1";
            }

            var foo2 = new Foo(Image.FromFile(@"C:\test.jpg"));
            foo2.Name = "Foo2";
        }
    }

    class Foo : IDisposable
    {
        public byte[] Bytes { get; set; }

        public Image Image { get; set; }

        public string Name { get; set; }

        public Foo(Image image)
        {
            this.Image = image;
            this.Bytes = new byte[image.Height * image.Width];
        }

        private bool disposedValue = false;  
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    Bytes = null;
                }

                Image?.Dispose();

                disposedValue = true;
            }
        }

        ~Foo()
        {
            Console.WriteLine($"Finalizer {this.Name}");
            Dispose(false);
        }

        public void Dispose()
        {
            Console.WriteLine($"using {this.Name}");
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
