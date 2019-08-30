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
            Console.WriteLine("date 1:" + d);

            int iii = d.Ticks % TimeSpan.TicksPerSecond;
            d = d.AddTicks(-(d.Ticks % TimeSpan.TicksPerSecond));
            Console.WriteLine("date 2:" + d);

            MyStandardClass cl =new MyStandardClass();
            Console.WriteLine(MySuperClass.GetName());
        }
    }
}
