namespace WiproDay3
{
     class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter the ProductId");
            int id=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the ProductName");
            String nm=Console.ReadLine();
            

            Product pr=new Product(id,nm);
            pr.PublicMthd();

            Customer cs=new Customer();
            Console.WriteLine("enter the customerid");
            cs.custid= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the customername");
            cs.custname = Console.ReadLine();
            cs.Display();


        }
    }
}