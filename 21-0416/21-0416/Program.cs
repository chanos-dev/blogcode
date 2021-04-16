using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_0416
{
    class Program
    {
        static void Main(string[] args)
        {
            var contentsPath = @"Sample";
            var zipPath = Path.Combine(contentsPath, "sample.zip");

            Zip.CreateZip(contentsPath, zipPath, "txt");
            Zip.ExtractZip(zipPath, Path.Combine(contentsPath, "zipFolder"));
        } 
    }
}
