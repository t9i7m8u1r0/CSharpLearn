using System;

namespace Task1
{
    class Program
    {
        static void Main()
        {
            MyException[] myExceptions = new MyException[5]
            {
                new MyException("MyException1"),
                new MyException("MyException2"),
                new MyException("MyException3"),
                new MyException("MyException4"),
                new MyException("MyException5")
            };

            for (int i = 0; i < myExceptions.Length; i++)
            {
                try
                {
                    throw myExceptions[i];
                }
                catch (MyException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine();
                }
            }
        }
    }
}