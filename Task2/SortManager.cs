using System;

namespace Task2
{
    class SortManager
    {
        public event Action<int>? SortRequested;

        public void RequestSort(int choice)
        {
            SortRequested?.Invoke(choice);
        }
    }
}