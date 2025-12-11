using System;

namespace CSharpLearn
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {
            //задание 9.2.2

            try
            {
                throw new ArgumentOutOfRangeException();
            }

            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }

            finally
            {
                Console.WriteLine("Сработал блок finally");
            }
        }
    }
}