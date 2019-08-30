﻿using ClassLibraryNETStandard;
using MyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExperiments
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime d = new DateTime(2019, 11, 1, 12, 15, 32);

            d = d.AddTicks(-(d.Ticks % TimeSpan.TicksPerSecond));

            MyStandardClass cl =new MyStandardClass();
            Console.WriteLine(MySuperClass.GetName());
        }
    }
}