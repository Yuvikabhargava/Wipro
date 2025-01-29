using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wiproday3;

internal class Customer
{
    public int custId;
    public string custName;

    public void Display()
    {
        Console.WriteLine($"CustomerId:{custId} \n CustomerName: {custName}");
    }
}