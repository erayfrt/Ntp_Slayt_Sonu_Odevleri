using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slayt4._5
{
    internal class Program
    {
        static int buyukBul(int a, int b)
        {
            if (a > b)
                return a;
            return b;
        }
        static void Main(string[] args)
        {
            int s1, s2;
            Console.WriteLine("1. sayıyı girin");
            s1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. sayıyı girin");
            s2=Convert.ToInt32(Console.ReadLine());

            int enbuyuk=buyukBul(s1, s2);
            Console.WriteLine("En büyük: {0}\'dir", enbuyuk);

            Console.ReadKey();
        }
    }
}
