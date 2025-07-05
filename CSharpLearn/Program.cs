using System;
class MainClass
{
    public static void Main(string[] args)
    {
        ShowUserInfo(GetUserInfo());
    }
    public static (string, string, int, string[], string[]) GetUserInfo()
    {
        Console.Write("Введите имя: ");
        string firstName = Console.ReadLine();

        Console.Write("Введите фамилию: ");
        string lastName = Console.ReadLine();

        Console.Write("Введите свой возраст: ");
        int age = CheckNumber();

        string[] petName = new string[0];

        Console.Write("Есть ли у вас питомцы (Да/Нет)? ");
        string hasPet = Console.ReadLine();

        if (hasPet == "Да")
        {
            Console.Write("Сколько? ");
            petName = GetNames(CheckNumber());
        }

        Console.Write("Сколько у вас любимых цветов? ");
        string[] favColor = GetNames(CheckNumber());

        return (firstName, lastName, age, petName, favColor);
    }
    public static int CheckNumber()
    {
        int number;
        string input;

        do
        {
            input = Console.ReadLine();
        }
        while (!int.TryParse(input, out number) || number <= 0);

        return number;
    }
    public static string[] GetNames(int count)
    {
        string[] names = new string[count];

        for (int i = 0; i < names.Length; i++)
        {
            Console.Write($"Введите номер {i + 1}: ");
            names[i] = Console.ReadLine();
        }

        return names;
    }
    public static void ShowUserInfo((string, string, int, string[], string[]) info)
    {
        Console.WriteLine($"\n{info.Item2} {info.Item1}, возраст: {info.Item3}");

        if (info.Item4.Length > 0)
        {
            Console.WriteLine("Ваши питомцы:");

            for (int i = 0; i < info.Item4.Length; i++)
            {
                Console.WriteLine($"{i + 1}) {info.Item4[i]}");
            }
        }

        Console.WriteLine("Ваши любимые цвета:");
        for (int i = 0; i < info.Item5.Length; i++)
        {
            Console.WriteLine($"{i + 1}) {info.Item5[i]}");
        }
    }
}