using wiproday4;

namespace wiproday4
{ 
    internal class Program
    {
        private static void Main(string[] args)
        {

            Student stu = new Student();
            stu.Stuid = 110;
            stu.Name = "Siya";
            stu.Age = 4;
            Console.WriteLine(stu.Stuid);
            Console.WriteLine(stu.Name);
            Console.WriteLine(stu.Age);
            //stu.SId = 111;//set accessor will invoke
            //Console.WriteLine(stu.SId);//get accessot will invoke
        }
    }
}