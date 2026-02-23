using System;

namespace Task1;

class Program
{
    static void Main()
    {
        ISummable summable = new Calculator();

        try
        {
            Console.Write("Введите первое число: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int b = int.Parse(Console.ReadLine());

            int result = summable.Sum(a, b);
            Console.WriteLine($"Результат: {result}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Вы ввели не число!");
        }
        finally
        {
            Console.WriteLine("Работа программы завершена");
        }
    }
}