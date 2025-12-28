using System;

namespace CSharpLearn
{
    class MainClass
    {
        delegate void SomeDelegate(int a, int b);

        static void FirstFunction(int a, int b)
        {
            Console.WriteLine(a - b);
        }

        static void SecondFunction(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        static void Main(string[] args)
        {
            //9.3.4

            SomeDelegate someDelegate = FirstFunction;

            someDelegate += SecondFunction;

            someDelegate -= SecondFunction;

            someDelegate.Invoke(1, 2);
        }
    }
}