using System;

namespace CSharpLearn
{
    class Car { }

    class Lexus : Car { }

    class MainClass
    {
        delegate Car carDelegate();

        static Lexus LexusMethod()
        {
            return null;
        }
        static void Main(string[] args)
        {
            //9.4.2

            carDelegate c = LexusMethod;
        }
    }
}