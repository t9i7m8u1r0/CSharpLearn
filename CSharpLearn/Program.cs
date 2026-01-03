using System;

namespace CSharpLearn
{
    class MainClass
    {
        delegate void ShowMessageDelegate(string message);

        static void Main(string[] args)
        {
            //9.3.12

            ShowMessageDelegate showMessageDelegate = delegate (string message)
            {
                Console.WriteLine(message);
            };

            showMessageDelegate.Invoke("Hello World!");
        }
    }
}