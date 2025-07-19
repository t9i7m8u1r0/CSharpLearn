using System;
class MainClass
{
    public static void Main(string[] args)
    {
        
    }
}

class Rectangle
{
    public uint a;
    public uint b;

    public Rectangle()
    {
        a = 6;
        b = 4;
    }

    public Rectangle(uint square)
    {
        a = square;
        b = square;
    }

    public Rectangle(uint first, uint second)
    {
        a = first;
        b = second;
    }

    public static uint Square(uint a, uint b)
    {
        uint area = a * b;
        return area;
    }
}