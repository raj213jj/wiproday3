﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WiproDay4Oops
{
    internal class Manager : Department

    {
           public string Mangername { get; set; }
        public override void Display()
        {
            base.Display();
            Console.WriteLine(Mangername);
        }
         

    }
}
