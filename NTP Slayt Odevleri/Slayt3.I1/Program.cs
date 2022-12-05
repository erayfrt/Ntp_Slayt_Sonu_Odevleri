using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slayt3.I1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0, a, n;
            Console.WriteLine("Bir sayı girin: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Artım miktarı: ");
            a = Convert.ToInt32(Console.ReadLine());

            for (; i < n;)
            {
                Console.Write("{0}", i);
                i += a;
            }
            Console.ReadKey();

        }
    }
}
