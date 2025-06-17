using System;
class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите своё имя");
        string name = Console.ReadLine();

        for (int i = name.Length - 1;  i >= 0; i--)
        {
            Console.Write(name[i]);
        }
    }
}