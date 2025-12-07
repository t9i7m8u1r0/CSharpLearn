using System;

namespace CSharpLearn
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {
            //задание 9.1.4

            Exception exception = new Exception("Исключение!");
            exception.HelpLink = "www.google.com";
        }
    }
}