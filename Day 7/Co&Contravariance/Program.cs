using Co;
namespace Cocontravariance;


internal delegate Vehicle delveh();//created delegate returning Vehicle as teurn type
internal delegate void delcontra(Car car);
internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Vehicle vhl = new();
        delveh delv = new(vhl.CreateVehicle);

        Car cr = new();
        //Covarience - accepting derived class as return type where base class is expected
        delv = new delveh(cr.CreateCar);//accepted

        //contravariance - Display methd with base class parameter is accepted where derived class parameter is expected
        delcontra delcont = new delcontra(vhl.Display);
        delcont.Invoke(cr);

        delcont += cr.DisplayCar;

    }

}