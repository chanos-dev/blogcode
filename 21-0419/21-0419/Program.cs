using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_0419
{
    public class NamedPipeControl
    {
        private const int TIMEOUT = 10000;

        private string PipeName { get; set; }

        public NamedPipeServerStream PipeServerStream { get; set; }
        public NamedPipeClientStream PipeClientStream { get; set; }

        public NamedPipeControl(string name)
        {
            PipeName = name;
        }

        public async void ServerOpen()
        {
            PipeServerStream = new NamedPipeServerStream(PipeName);

            Console.WriteLine("Wait a client");
            PipeServerStream.WaitForConnection();
            Console.WriteLine("Connected.");

            while(PipeServerStream.IsConnected)
            {
                var read = new byte[4096]; 

                await PipeServerStream.ReadAsync(read, 0, read.Length);

                var msg = Encoding.UTF8.GetString(read).TrimEnd('\0');

                Console.WriteLine(msg);
            }
        }

        public void ClientOpen()
        {
            PipeClientStream = new NamedPipeClientStream(PipeName);

            PipeClientStream.Connect(TIMEOUT);
        }

        public async void Write(string msg)
        {
            var write = Encoding.UTF8.GetBytes(msg);

            await PipeClientStream.WriteAsync(write, 0, write.Length);
            PipeClientStream.Flush();
        }
    }
}
