using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slayt7._1
{
    class Deneme
    {
        public int a, b;
        public Deneme(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public static int Topla(int x, int y)
        {
            return x + y;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Slayt7._1.Deneme d = new Slayt7._1.Deneme(1, 2);
            Console.WriteLine(d.a);
            Console.WriteLine(Slayt7._1.Deneme.Topla(2,3));
            Console.ReadKey();
        }
    }
}
