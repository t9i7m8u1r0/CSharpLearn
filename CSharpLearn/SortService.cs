using System;

namespace CSharpLearn
{
    class SortService
    {
        string[] surnames = { "Петров", "Иванов", "Сидоров", "Волков", "Зайцев" };

        public void SortRequest(int choice)
        {
            if (choice == 1)
            {
                Array.Sort(surnames);
            }
            else if (choice == 2)
            {
                Array.Sort(surnames);
                Array.Reverse(surnames);
            }

            foreach (var s in surnames)
            {
                Console.WriteLine(s);
            }
        }
    }
}