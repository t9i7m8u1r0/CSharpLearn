using System;
using System.Drawing;
using System.Xml.Linq;
class MainClass
{
    public static void Main(string[] args)
    {
        string[] favcolors = new string[3];

        for (int i = 0; i < favcolors.Length; i++)
        {
            favcolors[i] = Console.ReadLine();
        }

        ShowColors(favcolors[0], favcolors[2]);
    }

    static void ShowColors(params string[] favcolors)
    {
        Console.WriteLine("Ваши любимые цвета:");
        foreach (var color in favcolors)
        {
            Console.WriteLine(color);
        }
    }
}