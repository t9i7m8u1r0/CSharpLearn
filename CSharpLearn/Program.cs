using System;
class MainClass
{
    public static void Main(string[] args)
    {
        (string Name, string Type, double Age, int NameCount) Pet;

        Console.Write("Введите имя питомца: ");
        Pet.Name = Console.ReadLine();

        Console.Write("Введите тип питомца: ");
        Pet.Type = Console.ReadLine();

        Console.Write("Введите возраст питомца: ");
        Pet.Age = (Convert.ToDouble(Console.ReadLine()));

        Pet.NameCount = Pet.Name.Length;
        Console.Write($"Длина имени питомца: {Pet.NameCount}");
    }
}