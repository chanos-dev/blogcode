using _21_0419;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_0419_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            NamedPipeControl Client = new NamedPipeControl("chanos");

            Client.ClientOpen();

            while(true)
            {
                Client.Write(Console.ReadLine());
            }
        }
    }
}
