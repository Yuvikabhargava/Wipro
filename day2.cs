namespace wiprosampleproject
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Employee emp = new Employee();
            emp.emp_Id = 111;
            emp.name = "Test";

            Console.WriteLine($"Employee ID: {emp.emp_Id]");
            Console.₩riteLine(S"Employee Name:{emp.name)");


            Console.WriteLine("Enter the Employee Id:");
            int id = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter the Employee Name:");
            string name = Console.ReadLine();


            Employee emp2 = new Employee(id, name);
        }
    }
}