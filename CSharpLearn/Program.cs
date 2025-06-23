using System;
class MainClass
{
    static int[] GetArrayFromConsole()
    {
        var result = new int[5];

        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine("Введите элемент массива номер {0}", i + 1);
            result[i] = int.Parse(Console.ReadLine());
        }

        int temp;
        for (int i = 0; i < result.Length; i++)
        {
            for (int j = i+1; j < result.Length; j++)
            {
                if (result[i] > result[j])
                {
                    temp = result[j];
                    result[j] = result[i];
                    result[i] = temp;
                }
            }
            Console.WriteLine(result[i]);
        }
        return result;
    }
    public static void Main(string[] args)
    {
        GetArrayFromConsole();
    }
}