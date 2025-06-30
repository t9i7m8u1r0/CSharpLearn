﻿using System;
class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine(PowerUp(3, 4));
    }
    private static int PowerUp(int N, byte pow = 1)
    {
        if (pow == 0)
        {
            return 1;
        }
        else
        {
            if (pow == 1)
            {
                return N;
            }
            else
            {
                return N * PowerUp(N, --pow);
            }
        }
    }
}