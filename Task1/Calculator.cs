using System;

namespace Task1;

class Calculator : ISummable
{
    public int Sum(int a, int b)
    {
        return a + b;
    }
}