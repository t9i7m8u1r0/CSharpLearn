using System;

namespace CSharpLearn
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {
            //7.2.12
        }
    }

    class Obj
    {
        public int Value;

        public static Obj operator +(Obj first, Obj second)
        {
            return new Obj
            {
                Value = first.Value + second.Value
            };
        }

        public static Obj operator -(Obj first, Obj second)
        {
            return new Obj
            {
                Value = first.Value - second.Value
            };
        }
    }
}