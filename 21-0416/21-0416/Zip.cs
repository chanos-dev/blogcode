using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_0416
{
    internal static class Zip
    {
        internal static void CreateZip(string contentsFolderPath, string saveZipPath, string extention = "*")
        {
            if (!Directory.Exists(contentsFolderPath))
                throw new DirectoryNotFoundException($"The directory is not found. \n{contentsFolderPath}");

            if (!Directory.Exists(saveZipPath))
                Directory.CreateDirectory(Path.GetDirectoryName(saveZipPath));

            using (var fs = new FileStream(saveZipPath, FileMode.Create, FileAccess.ReadWrite))
            using (var za = new ZipArchive(fs, ZipArchiveMode.Create))
            {
                foreach (var filePath in Directory.EnumerateFiles(contentsFolderPath, $"*.{extention}", SearchOption.AllDirectories))
                {
                    try
                    { 
                        za.CreateEntryFromFile(filePath, Path.GetFileName(filePath));
                                            
                        //var entry = za.CreateEntry(Path.GetFileName(filePath));
                        //using (var es = entry.Open())
                        //using (var writer = new StreamWriter(es))
                        //{
                        //    writer.Write(File.ReadAllText(filePath));
                        //}
                    }
                    catch
                    {
                        throw;
                    }
                }
            }
        }

        internal static void ExtractZip(string zipPath, string extractFolderPath)
        {
            if (!File.Exists(zipPath))
                throw new FileNotFoundException($"The file is not found. \n{zipPath}");

            if (!Directory.Exists(extractFolderPath))
                Directory.CreateDirectory(Path.GetDirectoryName(extractFolderPath));

            using (var zipArchive = ZipFile.OpenRead(zipPath))
            {
                foreach (var zipArchiveEntry in zipArchive.Entries)
                {
                    try
                    {
                        string folderPath = Path.GetDirectoryName(Path.Combine(extractFolderPath, zipArchiveEntry.FullName));

                        if (!Directory.Exists(folderPath))
                            Directory.CreateDirectory(folderPath);

                        zipArchiveEntry.ExtractToFile(Path.Combine(extractFolderPath, zipArchiveEntry.FullName));
                    }
                    catch
                    {
                        throw;
                    }
                }
            }
        }
    }
}
