using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistryLab
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"D:\3 курс\ОС\Лаба1\Report.txt";

            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Explorer\FileExts"))
            {
                using (StreamWriter sw = File.CreateText(filePath))
                {
                    foreach (string subkey in key.GetSubKeyNames())
                    {
                        if (subkey[0] == '.')
                        {
                            Console.WriteLine(subkey);
                            sw.WriteLine(subkey);
                        }
                    }
                }        
            }
            Console.WriteLine("COMPLETE");
            Console.ReadLine();
        }
    }
}
