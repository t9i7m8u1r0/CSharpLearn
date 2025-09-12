﻿using System;

namespace CSharpLearn
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {
            //7.2.7
        }
    }

    class A
    {
        public virtual void Display()
        {
            Console.WriteLine("A");
        }
    }

    class B : A
    {
        public new void Display()
        {
            Console.WriteLine("B");
        }
    }

    class C : A
    {
        public override void Display()
        {
            Console.WriteLine("C");
        }
    }

    class D : B
    {
        public new void Display()
        {

        }
    }

    class E : C
    {
        public new void Display()
        {

        }
    }
}