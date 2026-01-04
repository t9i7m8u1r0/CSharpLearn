using System;

namespace CSharpLearn
{
    class MainClass
    {
        delegate int RandomNumberDelegate();

        static void Main(string[] args)
        {
            //9.3.15

            RandomNumberDelegate randomNumberDelegate = () => new Random().Next(0, 100);

            int result = randomNumberDelegate.Invoke();

            Console.WriteLine(result);
        }
    }
}