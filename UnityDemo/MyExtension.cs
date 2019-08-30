using System;
using System.Collections.Generic;
using System.Text;

namespace UnityDemo
{
   public static class MyExtension
    {
        public static int MySuperExtentionMethod(this String s)
        {
            return 123;
        }
    }
}
