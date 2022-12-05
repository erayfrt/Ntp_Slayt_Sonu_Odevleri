using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slayt4._7
{
    internal class Program
    {
        static void diziYaz(int[] a, int sekil)
        {
            if (sekil == 0)
            {
                foreach (object o in a)
                {
                    Console.Write(o.ToString() + " ");
                }
                Console.WriteLine();
            }
            else if (sekil == 1)
            {
                int x = 1;
                foreach (object o in a)
                {
                    Console.Write("{0,5}", o.ToString());
                    if (x % 3 == 0) Console.WriteLine();
                    x++;
                }
            }
            else
            {
                foreach (object o in a)
                {
                    Console.WriteLine(o.ToString());
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int[] dizi = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            diziYaz(dizi, 0);
            diziYaz(dizi, 1);
            diziYaz(dizi, 2);

            Console.ReadKey();
        }
    }
}
