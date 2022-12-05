using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slayt9._3
{
    
        class Kedi
        {
            protected int ayakSayisi = 4;
            public void yakalaAv()
            {
                Console.WriteLine("Kedi sinifi Av yakaladi");
                Console.ReadLine();
        }
        }
        class Kaplan : Kedi
        {
            public Kaplan()
            {
                Console.WriteLine("Ayak Sayisi="+ayakSayisi);
                Console.ReadLine();
            }
        }
        internal class Program
        {
        static void Main(string[] args)
        {
            Kedi kd = new Kedi();
            kd.yakalaAv();
            Kaplan kp = new Kaplan();
            kp.yakalaAv();
        }
    }
}
