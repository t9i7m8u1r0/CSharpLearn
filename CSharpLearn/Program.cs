using System;
using System.IO;

namespace CSharpLearn
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {
            //задание 8.3.1

            string path = @"C:\Users\username\source\repos\CSharpLearn\CSharpLearn\Program.cs";

            string textInFile = File.ReadAllText(path);

            Console.WriteLine(textInFile);
        }
    }
}