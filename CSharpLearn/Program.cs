using System;

namespace CSharpLearn
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {
            //7.6.7
        }
    }

    class Car<T>
    {
        public T Engine;

        public virtual void ChangePart<T>(T newPart) { }
    }
    class ElectricEngine { }
    class GasEngine { }
    class Battery { }
    class Differential { }
    class Wheel { }
}