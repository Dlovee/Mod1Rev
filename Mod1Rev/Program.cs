using System;

namespace Mod1Rev
{
    class Program
    {
        static void Main(string[] args)
        {
            // Call the method to calculate the area of a circle with radius 5
            double circleArea = CalculateCircleArea(5);
            Console.WriteLine("Circle Area: " + circleArea);

            // Call the method to calculate the area of a triangle with baseLength 10 and height 5
            double triangleArea = CalculateTriangleArea(10, 5);
            Console.WriteLine("Triangle Area: " + triangleArea);

            // Call the method to calculate the area of a rectangle with length 10 and width 5
            double rectangleArea = CalculateRectangleArea(10, 5);
            Console.WriteLine("Rectangle Area: " + rectangleArea);

            // Call the method to calculate the area of a square with side 5
            double squareArea = CalculateSquareArea(5);
            Console.WriteLine("Square Area: " + squareArea);

            // Circle
            Console.WriteLine("Enter the radius of the circle:");
            double circleRadius = Convert.ToDouble(Console.ReadLine());
            double inputCircleArea = CalculateCircleArea(circleRadius);
            Console.WriteLine($"The area of the circle is: {inputCircleArea}");

            // Triangle
            Console.WriteLine("Enter the base and height of the triangle:");
            double triangleBase = Convert.ToDouble(Console.ReadLine());
            double triangleHeight = Convert.ToDouble(Console.ReadLine());
            double inputTriangleArea = CalculateTriangleArea(triangleBase, triangleHeight);
            Console.WriteLine($"The area of the triangle is: {inputTriangleArea}");

            // Rectangle
            Console.WriteLine("Enter the length and width of the rectangle:");
            double rectangleLength = Convert.ToDouble(Console.ReadLine());
            double rectangleWidth = Convert.ToDouble(Console.ReadLine());
            double inputRectangleArea = CalculateRectangleArea(rectangleLength, rectangleWidth);
            Console.WriteLine($"The area of the rectangle is: {inputRectangleArea}");

            // Square
            Console.WriteLine("Enter the side length of the square:");
            double squareSide = Convert.ToDouble(Console.ReadLine());
            double inputSquareArea = CalculateSquareArea(squareSide);
            Console.WriteLine($"The area of the square is: {inputSquareArea}");
        }

        // Create a method that calculates the area of a circle
        static double CalculateCircleArea(double radius)
        {
            // Use the formula for the area of a circle: π * r²
            // Math.PI provides the value of π, and radius * radius gives r²
            return Math.PI * radius * radius;
        }

        // Create a method that calculates the area of a triangle
        static double CalculateTriangleArea(double baseLength, double height)
        {
            // Use the formula for the area of a triangle: (baseLength * height) / 2
            // Multiply baseLength and height, then divide by 2
            return (baseLength * height) / 2;
        }

        // Create a method that calculates the area of a rectangle
        static double CalculateRectangleArea(double length, double width)
        {
            // Use the formula for the area of a rectangle: length * width
            // Multiply length and width
            return length * width;
        }

        // Create a method that calculates the area of a square
        static double CalculateSquareArea(double side)
        {
            // Use the formula for the area of a square: side * side
            // Multiply the side by itself
            return side * side;
        }
    }
}
