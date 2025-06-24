using System;
using System.Drawing;
using System.Xml.Linq;
class MainClass
{
    public static void Main(string[] args)
    {
        int num = 5;
        int[] array = new int[num];
        GetArrayFromConsole(ref num);
        Console.WriteLine(num);
    }
    public static void GetArrayFromConsole(ref int num)
    {
        num = 6;
    }
}