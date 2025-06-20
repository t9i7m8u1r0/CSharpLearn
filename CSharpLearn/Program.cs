using System;
class MainClass
{
    public static void Main(string[] args)
    {
        int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };

        int count = 0;

        for (int i = 0; i <= arr.GetUpperBound(0); i++)
        {
            for (int j = 0; j <= arr.GetUpperBound(1); j++)
            {
                if (arr[i,j] > 0)
                {
                    count++;
                }
            }
        }

        Console.WriteLine(count);
    }
}