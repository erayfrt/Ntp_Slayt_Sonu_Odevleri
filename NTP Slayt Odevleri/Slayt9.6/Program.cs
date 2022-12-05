using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slayt9._6
{
    internal class Program
    {
        public static void Goster(oto Oto)
        {
            Console.WriteLine(Oto.Tur);
            Console.WriteLine(Oto.MotorGucu);
            Console.WriteLine(Oto.Tork);
            Console.WriteLine(Oto.Renk);
        }
        static void Main(string[] args)
        {
            oto oto1 = new oto(75, 100, "Kırmızı");
            Goster(oto1);
            Console.WriteLine("--------");
            model1 oto2 = new model1("Fiat", 100, 110, "Beyaz");
            Goster(oto2);
            Console.WriteLine("--------");
            model2 oto3 = new model2("Renault", 100, 120, "Siyah");
            Goster(oto3);
            Console.ReadLine();
        }
    }
}
