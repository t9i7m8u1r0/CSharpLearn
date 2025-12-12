using System;

namespace CSharpLearn
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {
            //задание 9.2.3

            try
            {
                throw new RankException();
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.GetType());
            }

            finally
            {
                Console.WriteLine("Конец программы.");
            }
        }
    }
}