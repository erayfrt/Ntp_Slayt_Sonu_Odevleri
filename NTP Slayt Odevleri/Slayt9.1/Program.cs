using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace Slayt9._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            model1 oto1 = new model1();
            model2 oto2 = new model2();
            oto1.tur = "Sedan";
            oto1.silindir_sayisi = 4;
            oto1.subap_sayisi = 8;
            oto1.guc = 75;
            oto1.tork = 100;
            oto1.ozellikyaz();
            Console.WriteLine("********");
            oto2.model2_boy = 6;
            oto2.model2_agirlik = 900;
            oto2.model2_renk = "Kırmızı";
            oto2.ozellikyaz();
            Console.WriteLine("********");
            oto2.goster();
            Console.WriteLine("********");
            oto1.goster();
            Console.ReadLine();
        }
    }
}
