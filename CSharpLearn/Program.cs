using System;

namespace CSharpLearn
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {
            //задание 8.2.1

            string dirName = @"C:\";

            if (Directory.Exists(dirName))
            {
                int filesCount = Directory.GetFiles(dirName).Length;
                Console.WriteLine($"Количество файлов в \"{dirName}\": {filesCount}");

                int directoriesCount = Directory.GetDirectories(dirName).Length;
                Console.WriteLine($"Количество файлов в \"{dirName}\": {directoriesCount}");
            }

            else
            {
                Console.WriteLine("Директории не существует");
            }
        }
    }
}