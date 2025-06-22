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
    }
}