using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wiproday3;

class Product
{
    int Proid;
    string ProName;

    public Product(int id, string name)
    {
        Proid = id;
        ProName = name;
    }


    private void SampleMthd()
    {
        Console.WriteLine("Private Method");
    }

    public void PublicMthd()
    {
        Console.WriteLine("Public Method" + Proid + " " + ProName);
    }
}