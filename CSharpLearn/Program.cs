using System;
using System.Drawing;
class MainClass
{
    public static void Main(string[] args)
    {
        GetArrayFromConsole();

        int[] array = new int[5];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        SortArray(array);
    }
    public static int[] GetArrayFromConsole()
    {
        int[] result = new int[5];

        for (int i = 0; i < result.Length; i++)
        {
            result[i] = int.Parse(Console.ReadLine());
        }

        return result;
    }
    public static int[] SortArray(int[] array)
    {

        int temp;

        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] > array[j])
                {
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
        }
        
        return array;
    }
}