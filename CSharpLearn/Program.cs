using System;
using System.IO;

namespace CSharpLearn
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {
            //задание 8.3.2

            string path = @"C:\Users\t9i7m\source\repos\CSharpLearn\CSharpLearn\Program.cs";

            string newLine = "//" + DateTime.Now;

            File.AppendAllText(path, newLine);

            string textInFile = File.ReadAllText(path);

            Console.WriteLine(textInFile);
        }
    }
}