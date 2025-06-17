using System;
class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите своё имя");
        string name = Console.ReadLine();
        Console.WriteLine("Ваше имя по буквам:");
        foreach(char nameArr in name)
        {
            Console.Write(nameArr + " ");
        }
        Console.Write("Последняя буква вашего имени: " + name[name.Length - 1]);
    }
}