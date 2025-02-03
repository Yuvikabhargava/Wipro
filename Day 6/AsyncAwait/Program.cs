// See https://aka.ms/new-console-template for more information
// Asynchronous streams - IAsyncEnumerable<T>

async Task<List<int>> FetchNumbersAsync()
{
    await Task.Delay(1000); // Simulate a delay for data retrieval
    return new List<int>() { 21, 22, 23, 24, 25 };
}

// Waiting for all values from the asynchronous task
List<int> numberList = await FetchNumbersAsync();
foreach (var number in numberList)
{
    Console.WriteLine(number);
}

Console.WriteLine("End of first batch");

await foreach (var value in StreamNumbersAsync())
{
    Console.WriteLine(value);
}

// Method to return multiple values asynchronously
static async IAsyncEnumerable<int> StreamNumbersAsync()
{
    for (int i = 0; i < 8; i++)
    {
        await Task.Delay(800); // Simulate asynchronous operation
        yield return i;
    }
}

// Demonstrating different methods with async behavior
ShowNumbersSequential();
ShowNumbersInParallel();

static void ShowNumbersSequential()
{
    for (int i = 0; i < 6; i++)
    {
        Console.WriteLine(i);
        // Simulate delay using Task.Delay instead of Thread.Sleep
        Task.Delay(1500).Wait(); // Wait for 1.5 seconds
    }
}

static async void ShowNumbersInParallel()
{
    await Task.Run(() =>
    {
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(i);
            // Simulate some work with a slight delay
            Task.Delay(1200).Wait(); // Wait for 1.2 seconds
        }
    });
}
