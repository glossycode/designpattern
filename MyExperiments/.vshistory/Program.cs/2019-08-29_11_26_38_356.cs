using ClassLibraryNETStandard;
using Finecom.Quickline.Common.Helper;
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

            //DateTime? mayBeNull = GetDateTime();

            DateTime d = new DateTime(2019, 11, 1, 12, 15, 32);
            Console.WriteLine("date 1:" + d);

            d = d.AddTicks(-(d.Ticks % TimeSpan.TicksPerMinute));
            Console.WriteLine("date 2:" + d);


            Console.WriteLine("date 2:" + d);
            Console.WriteLine("GetLastDayOfMonth:" + d.GetLastDayOfMonth());

            MyStandardClass cl =new MyStandardClass();
            Console.WriteLine(MySuperClass.GetName());
        }

        
        
        private static DateTime? GetDateTime(AClassWithNullableObjects data)
        {
            //DateTime? date = null
            return null;
        }
    }
}
