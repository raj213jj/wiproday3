using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiproDay3
{
    public class Customer
    {
        public int custid;
        public string custname;


        public void Display()
        {
            Console.WriteLine($"Customerid :{custid} \nCustomername : {custname}");

        }
    }
}
