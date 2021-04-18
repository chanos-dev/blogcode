using _21_0419;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_0419_Server
{
    class Program
    {
        static void Main(string[] args)
        {
            NamedPipeControl Server = new NamedPipeControl("chanos");

            Server.ServerOpen();

            Console.ReadLine();
        }
    }
}
