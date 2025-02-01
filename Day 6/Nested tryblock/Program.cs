internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Entering outer try block.");

            int result = PerformDivision(10, 0);

            try
            {
                Console.WriteLine("Entering inner try block.");
                int[] numbers = { 10, 20, 30 };
                Console.WriteLine(numbers[5]);
            }
            catch (IndexOutOfRangeException indexEx)
            {
                Console.WriteLine("Handled in inner catch block: " + indexEx.Message);
            }
        }
        catch (DivideByZeroException divideEx)
        {
            Console.WriteLine("Handled in outer catch block: " + divideEx.Message);
        }
        catch (Exception generalEx)
        {
            Console.WriteLine("Generic error: " + generalEx.Message);
        }
        finally
        {
            Console.WriteLine("Execution finished.");
        }
    }

    private static int PerformDivision(int numerator, int denominator)
    {
        return numerator / denominator;
    }
}
