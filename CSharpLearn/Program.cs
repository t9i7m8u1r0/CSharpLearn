using System;
using System.IO;

namespace CSharpLearn
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {
            //задание 8.2.4

            string desktopDir = @"C:\Users\luft\Desktop\testFolder";
            string trashDir = @"C:\.Trash";

            if (Directory.Exists(desktopDir))
            {
                DirectoryInfo dirInfo = new DirectoryInfo(desktopDir);
                dirInfo.MoveTo(trashDir);
            }

            else
                Console.WriteLine($"Директории {desktopDir} не существует");
        }
    }
}