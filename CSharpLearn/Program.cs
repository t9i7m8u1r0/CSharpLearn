using System;
class MainClass
{
    public static void Main(string[] args)
    {
        
    }
}

class GeometricFigure
{
    class Triangle
    {
        public double sideA;
        public double sideB;
        public double sideC;

        public static double Area(double baseSide, double height)
        {
            double triangleArea = 0.5 * baseSide * height;
            return triangleArea;
        }

        public static double Perimeter(double firstSide, double secondSide, double thirdSide)
        {
            double trianglePerimeter = firstSide + secondSide + thirdSide;
            return trianglePerimeter;
        }
    }

    class Circle
    {
        public double radius;

        public static double Area(double radiusCircle)
        {
            double circleArea = Math.PI * radiusCircle * radiusCircle;
            return circleArea;
        }

        public static double Circumference(double radiusCircle)
        {
            double circumference = 2 * Math.PI * radiusCircle;
            return circumference;
        }
    }

    class Square
    {
        public double side;

        public static double Area(double side)
        {
            double squareArea = side * side;
            return squareArea;
        }

        public static double Perimeter(double side)
        {
            double squareArea = side * 4;
            return squareArea;
        }
    }
}