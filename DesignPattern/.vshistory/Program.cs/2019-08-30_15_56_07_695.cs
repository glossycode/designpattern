using DesignPattern.Behavioral;
using DesignPattern.Structural;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var patterns = new List<IPattern>() {
                new Adapter(),
                new Flyweight(),
                new Chain_of_Responsibility()
            };

            foreach (var p in patterns)
            {
                Console.WriteLine("Running " + p.GetType());
                Console.WriteLine("----------------------------------------------------------------");
                p.run();

                Console.WriteLine("================================================================");
                Console.WriteLine("");
            }

            Console.ReadKey();

        }
    }
}
