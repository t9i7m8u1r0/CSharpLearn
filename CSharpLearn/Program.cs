using System;

namespace CSharpLearn
{
    class MainClass
    {
        static void Main(string[] args)
        {
            //9.6.1 (HW-03) - Task 2

            try
            {
                Console.WriteLine("Введите 1 (А-Я) или 2 (Я-А):");

                if (!int.TryParse(Console.ReadLine(), out int userChoice))
                {
                    throw new MyException("Ввод должен быть числом");
                }

                if (userChoice != 1 && userChoice != 2)
                {
                    throw new MyException("Допустимы только значения 1 или 2");
                }

                SortManager sortManager = new SortManager();

                SortService sortService = new SortService();

                sortManager.SortRequested += sortService.SortRequest;

                sortManager.RequestSort(userChoice);
            }
            catch (MyException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine();
                Console.WriteLine("Программа завершена.");
            }
        }
    }
}