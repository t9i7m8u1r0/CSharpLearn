using System;
class MainClass
{
    public static void Main(string[] args)
    {
        (string name, int age) anketa = (name: Console.ReadLine(),
            age: Convert.ToInt32(Console.ReadLine()));

        Console.WriteLine(anketa);
    }
}