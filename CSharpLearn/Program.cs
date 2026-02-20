using System;

namespace CSharpLearn
{
    class Program
    {
        static void Main()
        {
            Writer writter = new Writer();

            ((IWriter)writter).Write();
        }
    }

    interface IWriter
    {
        void Write();
    }

    class Writer : IWriter
    {
        void IWriter.Write() { }
    }
}