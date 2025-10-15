using System;

namespace CSharpLearn
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {
            //7.6.9
        }
    }

    class Engine { }
    class ElectricEngine : Engine { }
    class GasEngine : Engine { }
    class CarPart { }
    class Battery : CarPart { }
    class Differential : CarPart { }
    class Wheel : CarPart { }

    class Car<T> where T : Engine
    {
        public T Engine;

        public virtual void ChangePart<T>(T newPart) where T : CarPart
        {

        }
    }
}