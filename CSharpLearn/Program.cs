﻿using System;

namespace CSharpLearn
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {
            //7.6.12
        }
    }

    abstract class Engine { }
    class ElectricEngine : Engine { }
    class GasEngine : Engine { }

    abstract class CarPart { }
    class Battery : CarPart { }
    class Differential : CarPart { }
    class Wheel : CarPart { }

    abstract class Car<TEngine> where TEngine : Engine
    {
        public TEngine Engine;

        public abstract void ChangePart<TPart>(TPart newPart) where TPart : CarPart;
    }
    class ElectricCar : Car<ElectricEngine>
    {
        public override void ChangePart<TPart>(TPart newPart)
        {

        }
    }
    class GasCar : Car<GasEngine>
    {
        public override void ChangePart<TPart>(TPart newPart)
        {

        }
    }
}