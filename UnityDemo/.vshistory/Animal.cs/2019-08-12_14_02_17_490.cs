using System;
using System.Collections.Generic;
using System.Text;

namespace UnityDemo
{
    class Animal : IAninal
    {
        bool IAninal.CanRun()
        {
            return true;
        }
    }
}
