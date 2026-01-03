using System;

namespace CSharpLearn
{
    class MainClass
    {
        delegate int RandomNumberDelegate();

        static void Main(string[] args)
        {
            //9.3.13

            RandomNumberDelegate randomNumberDelegate = delegate
            {
                return new Random().Next(0, 100);
            };

            int result = randomNumberDelegate.Invoke();

            Console.WriteLine(result);
        }
    }
}