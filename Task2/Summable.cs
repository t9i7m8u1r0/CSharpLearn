using System;

namespace Task2;

class Summable : ISummable
{
    readonly ILogger logger;

    public Summable(ILogger logger)
    {
        this.logger = logger;
    }

    public int Sum(int a, int b)
    {
        int result = a + b;

        logger.Log($"Выполнено сложение {a} и {b}");

        return result;
    }
}