using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user to enter the base of the triangle
        Console.Write("Enter the base of the triangle: ");
        double baseLength = Convert.ToDouble(Console.ReadLine());

        // Prompt the user to enter the height of the triangle
        Console.Write("Enter the height of the triangle: ");
        double height = Convert.ToDouble(Console.ReadLine());

        // Calculate the area of the triangle
        double area = (baseLength * height) / 2;

        // Display the calculated area
        Console.WriteLine($"The area of the triangle is: {area}");
    }
}
