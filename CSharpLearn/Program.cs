using System;
using System.Drawing;
using System.Xml.Linq;
class MainClass
{
    public static void Main(string[] args)
    {
        Console.Write("Напишите что-то: ");
        var modif = Console.ReadLine();

        Console.Write("Укажите глубину эха: ");
        var deep = int.Parse(Console.ReadLine());

        Echo(modif, deep);
    }
    public static void Echo(string saidworld, int deep)
    {
        var modif = saidworld;

        if (modif.Length > 2)
        {
            modif = modif.Remove(0, 2);
        }

        Console.WriteLine("..." + modif);

        if (deep > 1)
        {
            Echo(modif, deep - 1);
        }
    }
}