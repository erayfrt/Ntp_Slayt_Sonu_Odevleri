using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slayt3.I3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            Console.WriteLine("Bir tamsayı girin");
            sayi = Convert.ToInt32(Console.ReadLine());
            for (int bit = 32; bit >= 1; bit--)
            {
                Console.Write("{0}", (sayi >> bit - 1) & 1);
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
