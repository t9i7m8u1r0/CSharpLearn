using System;
using System.Drawing;
using System.Xml.Linq;
class MainClass
{
    public static void Main(string[] args)
    {
        int[] arr = new int[5];
        Console.WriteLine("Введите пять чисел");
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        int[] sortedask;
        int[] sorteddesk;

        SortArray(arr, out sorteddesk, out sortedask);

        Console.WriteLine("По возрастанию:");
        foreach (int i in sortedask)
        {
            Console.Write(i + " ");
        }

        Console.WriteLine("\nПо убыванию:");
        foreach (int i in sorteddesk)
        {
            Console.Write(i + " ");
        }
    }
    public static void SortArray(in int[] array, out int[] sorteddesc, out int[] sortedasc)
    {
        sortedasc = SortArrayAsc(array);
        sorteddesc = SortArrayDesc(array);
    }
    public static int[] SortArrayDesc(int[] array)
    {
        int[] sorted = new int[array.Length];
        for (int i = 0; i < array.Length;i++)
        {
            sorted[i] = array[i];
        }

        int temp;
        for (int i = 0; i < sorted.Length; i++)
        {
            for (int j = i + 1; j < sorted.Length; j++)
            {
                if (sorted[i] < sorted[j])
                {
                    temp = sorted[i];
                    sorted[i] = sorted[j];
                    sorted[j] = temp;
                }
            }
        }
        return sorted;
    }
    public static int[] SortArrayAsc(int[] array)
    {
        int[] sorted = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            sorted[i] = array[i];
        }

        int temp;
        for (int i = 0; i < sorted.Length; i++)
        {
            for (int j = i + 1; j < sorted.Length; j++)
            {
                if (sorted[i] > sorted[j])
                {
                    temp = sorted[i];
                    sorted[i] = sorted[j];
                    sorted[j] = temp;
                }
            }
        }
        return sorted;
    }
}