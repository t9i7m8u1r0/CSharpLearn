using System;
class MainClass
{
    public static void Main(string[] args)
    {
        int[] arr = {-3, -2, -1, 0, 1, 2, 3};

        int count = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > 0)
            {
                count++;
            }
        }

        Console.WriteLine(count);
    }
}