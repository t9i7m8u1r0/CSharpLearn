using System;

namespace CSharpLearn
{
    class Program
    {
        static void Main()
        {
            
        }
    }

    interface IWorker
    {
        void Build();
    }

    class Worker : IWorker
    {
        public void Build() { }
    }
}