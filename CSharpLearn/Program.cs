using System;

namespace CSharpLearn
{
    class Parent { }

    class Child : Parent { }

    class MainClass
    {
        delegate void ChildDelegate(Child child);

        static void ParentMethod(Parent parent) { }

        static void Main(string[] args)
        {
            //9.4.3

            ChildDelegate c = ParentMethod;
        }
    }
}