using System;

namespace CSharpLearn
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {
            //7.2.4
        }
    }

    class BaseClass
    {
        public virtual int Counter
        {
            get;
            set;
        }
    }

    class DerivedClass : BaseClass
    {
        public override int Counter
        {
            get
            {
                return Counter;
            }
            set
            {
                if (Counter >= 0)
                {
                    Counter = value;
                }
            }
        }
    }
}