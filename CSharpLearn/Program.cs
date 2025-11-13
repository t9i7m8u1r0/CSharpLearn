using System;
using System.IO;

namespace CSharpLearn
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {
            //задание 8.2.3

            string newDir = @"C:\NewTestFolder";
            string parentDir = @"C:\";

            if (!Directory.Exists(newDir))
            {
                int filesCount = Directory.GetFiles(parentDir).Length;
                Console.WriteLine($"Количество файлов в \"{parentDir}\" до: {filesCount}");

                int directoriesCount = Directory.GetDirectories(parentDir).Length;
                Console.WriteLine($"Количество папок в \"{parentDir}\" до: {directoriesCount}");

                Directory.CreateDirectory(newDir);
                Console.WriteLine($"\nПапка {newDir} создана.\n");

                filesCount = Directory.GetFiles(parentDir).Length;
                Console.WriteLine($"Количество файлов в \"{parentDir}\" после: {filesCount}");

                directoriesCount = Directory.GetDirectories(parentDir).Length;
                Console.WriteLine($"Количество папок в \"{parentDir}\" после: {directoriesCount}");
            }

            else
            {
                DirectoryInfo dirInfo = new DirectoryInfo(newDir);

                dirInfo.Delete(true);
                Console.WriteLine($"Директория {newDir} удалена.");
            }
        }
    }
}