using System;
using System.Collections.Generic;
using System.Text;

namespace UnityDemo
{
   public class Animal : IAninal
    {
        bool IAninal.CanRun()
        {
            return true;
        }
    }
}
