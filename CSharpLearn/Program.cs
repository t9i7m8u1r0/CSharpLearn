using System;
using System.Drawing;
using System.Xml.Linq;
class MainClass
{
    public static void Main(string[] args)
    {
        int[] x = { 1, 2, 3 };
        GetArrayFromConsole();
        SortArray(x);
    }
    public static int[] GetArrayFromConsole(int num = 5)
    {
        var result = new int[num];
        for (int i = 0;  i < result.Length; i++)
        {
            result[i] = int.Parse(Console.ReadLine());
        }
        return result;
    }
    public static int[] SortArray(int[] result)
    {
        int temp = 0;
        for (int i = 0; i < result.Length;i++)
        {
            for (int j = i + 1; j < result.Length; j++)
            {
                if (result[i] > result[j])
                {
                    temp = result[i];
                    result[i] = result[j];
                    result[j] = temp;
                }
            }
        }
        return result;
    }
}