using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slayt3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10; int b, c;
            b = a++; c = ++a;
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);
            Console.WriteLine("c = {0}", c);
            
            Console.ReadKey();
        }
    }
}
