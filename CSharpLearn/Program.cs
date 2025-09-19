using System;

namespace CSharpLearn
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {
            //7.2.14
        }
    }

    class IndexingClass
    {
        private int[] array;

        public IndexingClass(int[] array)
        {
            this.array = array;
        }

        public int this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }
    }
}