using Microsoft.Win32;
using System;

namespace _24_0214
{
    static class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine($"Hello!! {string.Join(" / ", args)}");
            Console.ReadLine();
        }

        // 관리자 권한 필요
        static void RegisterCustomURLScheme()
        {
            string defaultKey = string.Empty;

            using (RegistryKey key = Registry.ClassesRoot.CreateSubKey("chanos2"))
            {
                key.SetValue("URL Protocol", "");

                using (RegistryKey shell = key.CreateSubKey("shell"))
                using (RegistryKey open = shell.CreateSubKey("open"))
                using (RegistryKey command = open.CreateSubKey("command"))
                    command.SetValue(defaultKey, @"""D:\24-0214.exe"" ""%1""");
            }
        }
    }
}
