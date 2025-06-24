using System;
using System.Drawing;
using System.Xml.Linq;
class MainClass
{
    public static void Main(string[] args)
    {
        int[] array = { 1, 2, 4, 3, 5 };

        ShowArray(array);
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
        int temp;
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
    public static void ShowArray(int[] arr, bool x = false)
    {
        int[] temp = arr;
        if (x == true)
        {
            temp = SortArray(arr);
        }
        
        foreach (int i in temp)
        {
            Console.WriteLine(i);
        }
    }
}