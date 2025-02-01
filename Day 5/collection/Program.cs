using System;
using System.Collections;

class Program
{
    static void Main()
    {
        ArrayList list = new ArrayList();
        list.Add(123); // Boxing
        list.Add("Tech");
        list.Add(false);

        Console.WriteLine("ArrayList Content:");
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine($"Capacity: {list.Capacity}");
        Console.WriteLine($"Item Count: {list.Count}");
        Console.WriteLine();

        string[] places = { "Mumbai", "Delhi", "Pune", "Kolkata" };
        list.AddRange(places);

        Console.WriteLine("Updated ArrayList Content:");
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine();
        Console.WriteLine($"Capacity: {list.Capacity}");
        Console.WriteLine($"Item Count: {list.Count}");

        list.Insert(2, 500);
        Console.WriteLine("After Inserting an item:");
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }

        int[] numbers = { 100, 200, 300 };
        list.InsertRange(5, numbers);
        Console.WriteLine("After Inserting a range:");
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine($"Capacity: {list.Capacity}");
        Console.WriteLine($"Item Count: {list.Count}");

        list.Remove("Mumbai");
        Console.WriteLine("After Removing an item:");
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }

        list.RemoveAt(3);
        Console.WriteLine("After Removing an item by index:");
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }

        list.RemoveRange(1, 2);
        Console.WriteLine("After Removing a range of items:");
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }

        list[1] = "Updated";
        Console.WriteLine("After Updating an item:");
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine($"Contains 'Delhi': {list.Contains("Delhi")}");

        ArrayList numbersList = new ArrayList();
        numbersList.Add(45);
        numbersList.Add(60);
    }
}


