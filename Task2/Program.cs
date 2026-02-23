using System;

namespace Task2;

class Program
{
    static void Main()
    {
        ILogger logger = new Logger();
        ISummable calculator = new Summable(logger);

        try
        {
            Console.Write("Введите первое число: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int b = int.Parse(Console.ReadLine());

            int result = calculator.Sum(a, b);
            logger.Log($"Результат: {result}");
        }
        catch (FormatException)
        {
            logger.Error("Некорректный ввод!");
        }
    }
}