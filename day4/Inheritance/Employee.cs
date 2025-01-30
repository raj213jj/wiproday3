using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiproDay4Oops
{
    internal class Employee
    {
        //properties
        public int Empid { get; set; }
        public string Empname { get; set; }


        public virtual void Display()
        {
            Console.WriteLine(Empid + " " + Empname);
        }


    }
}
