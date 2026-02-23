using System;

namespace Task2;

interface ILogger
{
    void Log(string message);
    void Error(string message);
}