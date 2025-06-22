using System;
class MainClass
{
    public static void Main(string[] args)
    {
        (string name,
            string surname,
            string login,
            int loginLength,
            bool hasPet,
            double age,
            string[] favColors) User;

        Console.Write("Введите имя: ");
        User.name = Console.ReadLine();

        Console.Write("Введите фамилию: ");
        User.surname = Console.ReadLine();

        Console.Write("Введите логин: ");
        User.login = Console.ReadLine();

        User.loginLength = User.login.Length;

        Console.Write("Есть ли у вас животные? Введите \"Да\" или \"Нет\": ");
        string inputHasPet = Console.ReadLine();
        User.hasPet = inputHasPet == "Да" ? true : false;

        Console.Write("Введите возраст пользователя: ");
        User.age = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите три любимых цвета пользователя: ");
        User.favColors = new string[3];
        for (int i = 0; i < User.favColors.Length; i++)
        {
            User.favColors[i] = Console.ReadLine();
        }
    }
}