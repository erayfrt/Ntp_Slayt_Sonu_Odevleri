using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlaytI0._5
{
    delegate void OlayYoneticisi();
    class AnaProgram
    {
        static void Main()
        {
            AnaProgram nesne = new AnaProgram();
            nesne.Olay += new OlayYoneticisi(Metot);
            nesne.Olay();
            Console.Read();
        }

        static void Metot() { Console.WriteLine("Butona tıklandı."); }
        event OlayYoneticisi Olay;
        
    }
}
