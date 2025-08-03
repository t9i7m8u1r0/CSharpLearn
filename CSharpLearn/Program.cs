using System;
class MainClass
{
    public static void Main(string[] args)
    {
        
    }
}
class Bus
{
    public int? Load;

    public void PrintStatus()
    {
        if (Load.HasValue && Load > 0)
        {
            Console.WriteLine($"В автобусе {Load.Value} человек");
        }
        else
        {
            Console.WriteLine("Пусто");
        }
    }
}