using System;

namespace CSharpLearn
{
    class MyException : Exception
    {
        public MyException(string message) : base(message)
        {
            
        }
    }
}