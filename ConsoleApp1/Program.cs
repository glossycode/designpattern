using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            InitLog4Net();
            log4net.LogManager.GetLogger(typeof(Program)).Info("Test log");
        }

        private static void InitLog4Net()
        {
            log4net.Config.XmlConfigurator.Configure();            
        }
    }
}
