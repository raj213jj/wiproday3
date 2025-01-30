using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiproDay4Oops
{
    internal class Department : Employee
    {
        public string DeptName { get; set; }
        public decimal Salary { get; set; }

        public virtual void Display()
        {
            base.Display();
            Console.WriteLine(DeptName + " " + Salary); 
        }
    }
}
