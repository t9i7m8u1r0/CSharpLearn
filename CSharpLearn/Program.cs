using System;
class MainClass
{
    public static void Main(string[] args)
    {
        int t = 0;
        do
        {
            Console.WriteLine(t);
            Console.WriteLine("Write your favorite color");
            switch (Console.ReadLine()) { }
            t++;
        }
        while (t < 3);
    }
}