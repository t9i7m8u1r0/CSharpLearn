using System;

namespace CSharpLearn
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {
            //7.3.3
        }
    }

    abstract class ComputerPart
    {
        public abstract void Work();
    }

    class Processor : ComputerPart
    {
        public override void Work() { }
    }

    class MotherBoard : ComputerPart
    {
        public override void Work() { }
    }

    class GraphicCard : ComputerPart
    {
        public override void Work() { }
    }
}