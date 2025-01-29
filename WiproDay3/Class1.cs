using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiproDay3
{
    class Product
    {
        int Proid;
        String ProName;


        public Product(int id, String name)
        {
            Proid = id;
            ProName = name;
        }
    

       
        public void PublicMthd()
        {
            Console.WriteLine("Public Method" + Proid + " " + ProName);
        }
    }


}

