using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slayt4._6
{
    internal class Program
    {
        static int buyukBul(int a, int b)
        {
            if (a > b)
                return a;
            return b;
        }
        static int buyukBul3(int a, int b,int c)
        {
            return buyukBul (a, buyukBul(b, c));
        }
        static void Main(string[] args)
        {
            int s1, s2,s3;
            Console.WriteLine("1. sayıyı girin");
            s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. sayıyı girin");
            s2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3. sayıyı girin");
            s3 = Convert.ToInt32(Console.ReadLine());

            int enbuyuk = buyukBul3(s1, s2,s3);
            Console.WriteLine("En büyük: {0}\'dir", enbuyuk);

            Console.ReadKey();

        }
    }
}
