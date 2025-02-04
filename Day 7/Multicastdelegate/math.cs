using System;

namespace Multicastdelegate;

public delegate void MathActionDelegate(int num1, int num2);  // Delegate for math operations

internal class Operations
{
    // Addition
    public static void AddNumbers(int a, int b)
    {
        Console.WriteLine($"Sum: {a + b}");
    }

    // Subtraction
    public static void SubtractNumbers(int a, int b)
    {
        Console.WriteLine($"Difference: {a - b}");
    }

    // Multiplication
    public static void MultiplyNumbers(int a, int b)
    {
        Console.WriteLine($"Product: {a * b}");
    }

    // Division
    public static void DivideNumbers(int a, int b)
    {
        if (b != 0)
            Console.WriteLine($"Quotient: {a / b}");
        else
            Console.WriteLine("Division by zero is not allowed.");
    }
}
