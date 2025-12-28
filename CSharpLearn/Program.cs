using System;

namespace CSharpLearn
{
    class MainClass
    {
        delegate int SomeDelegate(int a, int b);

        static int SomeFunction(int a, int b)
        {
            return b - a;
        }

        public static void Main(string[] args)
        {
            //9.3.2

            SomeDelegate someDelegate = SomeFunction;

            int result = someDelegate.Invoke(1, 2);

            Console.WriteLine(result);
        }
    }
}