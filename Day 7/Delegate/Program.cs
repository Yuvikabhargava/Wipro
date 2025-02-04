internal class Program
{
//delegate refers to a method
//1.Signature of the delegate should match with the signature of targ
public delegate void delsample(); //declaring a delegate
private static void Main(string[] args)
    {
        //2.create instance for the delegate - set the target method
        delsample del = new delsample(Display);
        //3.Invoke the delegate
        del();//calling display method
    }
static void Display()
{
        Console.WriteLine("Welcome to delegates");
      }
    }