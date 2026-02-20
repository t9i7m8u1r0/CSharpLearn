using System;

namespace CSharpLearn
{
    class Program
    {
        static void Main()
        {
            Worker worker = new Worker();

            ((IWorker)worker).Build();
        }
    }

    interface IWorker
    {
        void Build();
    }

    class Worker : IWorker
    {
        void IWorker.Build() { }
    }
}