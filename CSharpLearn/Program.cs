using System;

namespace CSharpLearn
{
    class MainClass
    {
        delegate void ShowMessageDelegate(string message);

        static void Main(string[] args)
        {
            //9.3.14

            ShowMessageDelegate showMessageDelegate = message => Console.WriteLine(message);

            showMessageDelegate.Invoke("Hello World!");
        }
    }
}