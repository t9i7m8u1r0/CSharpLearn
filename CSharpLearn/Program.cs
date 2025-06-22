using System;
class MainClass
{
    public static void Main(string[] args)
    {
        (string Name, string[] Dishes) User;
        User.Dishes = new string[5];

        User.Name = Console.ReadLine();

        for (int i = 0;  i < User.Dishes.Length; i++)
        {
            User.Dishes[i] = Console.ReadLine();
        }
    }
}