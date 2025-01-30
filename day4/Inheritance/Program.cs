using WiproDay4Oops;

namespace WiproDay4Oops
{

    internal class Program
    {
        private static void Main(string[] args)
        {
            //Department dpt = new Department();
            Manager mng = new Manager();
            Console.WriteLine("Give the Emmployee id and name");
            mng.Empid=Convert.ToInt32(Console.ReadLine());
            mng.Empname = Console.ReadLine();
            Console.WriteLine("Give the departmnet name and salary");
            mng.DeptName = Console.ReadLine();
            mng.Salary =Convert.ToDecimal( Console.ReadLine());
            Console.WriteLine("Give the Manager Name");
            mng.Mangername = Console.ReadLine();

            mng.Display();


        }
    }
}