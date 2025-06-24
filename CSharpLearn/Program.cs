using System;
using System.Drawing;
using System.Xml.Linq;
class MainClass
{
    public static void Main(string[] args)
    {
        int age = 15;
        Console.WriteLine(age);
        ChangeAge(age);
        Console.WriteLine(age);

        //var someName = "Евгения";
        //Console.WriteLine(someName);

        //GetName(someName);

        //Console.WriteLine(someName);
    }
    public static void GetName(string name)
    {
        Console.WriteLine("Введите имя");
        name = Console.ReadLine();
    }
    public static void ChangeAge(int age)
    {
        age = 45;
        Console.WriteLine(age);
    }
}