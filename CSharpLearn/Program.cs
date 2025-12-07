using System;

namespace CSharpLearn
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {
            //задание 9.1.3

            Exception exception = new Exception();
            exception.Data.Add("Дата создания исключения: ", DateTime.Now);
        }
    }
}