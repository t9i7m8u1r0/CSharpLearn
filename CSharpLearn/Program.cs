using System;
class MainClass
{
    public static void Main(string[] args)
    {
        int[,] array = { { 1, 2, 3 }, { 5, 6, 7 } };
        foreach (int i in array)
        {
            Console.WriteLine(i);
        }
    }
}