using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slayt2._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object x;
            x = 10;
            Console.WriteLine(x.GetType());
            x = "B";
            Console.WriteLine(x.GetType());
            x = 8.78F;
            Console.WriteLine(x.GetType());
            x = false;
            Console.WriteLine(x.GetType());
            x = 5.436M;
            Console.WriteLine(x.GetType());

            Console.ReadKey();


        }
    }
}
