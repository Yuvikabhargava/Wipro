// See https://aka.ms/new-console-template for more information
using Multicastdelegate;
Console.WriteLine("Welcome to the Math Operations Program!");

MathActionDelegate mathDelegate = new MathActionDelegate(Operations.AddNumbers); // Add numbers initially

mathDelegate.Invoke(15, 25);  // Calling add using invoke
mathDelegate(5, 10);         // Calling add using direct delegate invocation

// Adding more operations (subtraction, multiplication, division) to the delegate chain
mathDelegate += Operations.SubtractNumbers;
mathDelegate += Operations.MultiplyNumbers;
mathDelegate += Operations.DivideNumbers;

Console.WriteLine("\nPerforming multiple operations on 50 and 30:");
mathDelegate(50, 30); // Add, subtract, multiply, and divide

// Removing division operation from the delegate chain
mathDelegate -= Operations.DivideNumbers;
Console.WriteLine("\nPerforming operations after removing division:");
mathDelegate(100, 20); // Add, subtract, and multiply

// Anonymous delegate example (Sum of three numbers)
Func<int, int, int, int> sumDelegate = delegate (int a, int b, int c)
{
    return a + b + c;
};
Console.WriteLine($"\nSum of three numbers: {sumDelegate(5, 10, 15)}");

// Lambda expression delegate (square of a number)
Func<int, int> squareDelegate = x => x * x;
Console.WriteLine($"\nSquare of 8: {squareDelegate(8)}");

// Action delegate for printing the sum of two numbers (void return type)
Action<int, int> printSumDelegate = (x, y) => Console.WriteLine($"Sum: {x + y}");
printSumDelegate(12, 18);

// Predicate delegate to check if a number is even
Predicate<int> isEvenCheck = num => num % 2 == 0;
int numberToCheck = 18;

if (isEvenCheck(numberToCheck))  // Invoking the predicate
{
    Console.WriteLine($"\n{numberToCheck} is even!");
}
else
{
    Console.WriteLine($"\n{numberToCheck} is odd!");
}
