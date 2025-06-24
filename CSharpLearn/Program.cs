using System;
using System.Drawing;
using System.Xml.Linq;
class MainClass
{
    public static void Main(string[] args)
    {
        int[] arr = new int[5];

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        SortArray(arr, out arr, out arr);
    }
    public static void SortArray(in int[] array, out int[] sorteddesc, out int[] sortedasc)
    {
        sortedasc = SortArrayAsc(array);
        sorteddesc = SortArrayDesc(array);
    }
    public static int[] SortArrayDesc(int[] sorteddesc)
    {
        int temp;
        for (int i = 0; i < sorteddesc.Length; i++)
        {
            for (int j = i + 1; j < sorteddesc.Length; j++)
            {
                if (sorteddesc[i] < sorteddesc[j])
                {
                    temp = sorteddesc[i];
                    sorteddesc[i] = sorteddesc[j];
                    sorteddesc[j] = temp;
                }
            }
        }
        foreach (int i in sorteddesc)
        {
            Console.WriteLine(i);
        }
        return sorteddesc;
    }
    public static int[] SortArrayAsc(int[] sortedasc)
    {
        int temp;
        for (int i = 0; i < sortedasc.Length; i++)
        {
            for (int j = i + 1; j < sortedasc.Length; j++)
            {
                if (sortedasc[i] > sortedasc[j])
                {
                    temp = sortedasc[i];
                    sortedasc[i] = sortedasc[j];
                    sortedasc[j] = temp;
                }
            }
        }
        foreach (int i in sortedasc)
        {
            Console.WriteLine(i);
        }
        return sortedasc;
    }
}