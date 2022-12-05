using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slayt6._7
{
    struct üniversite
    {
        public string fakulte, bolum, Ogr_gor;
        public üniversite(string a, string b, string c)
        {
            fakulte = a; bolum = b; Ogr_gor = c;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            üniversite k1 = new üniversite("Teknoloji Fakültesi", "Yazılım Mühendisliği", "2.sınıf");
            üniversite k2;
            Console.WriteLine(k1.fakulte);
            Console.WriteLine(k1.bolum);
            Console.WriteLine(k1.Ogr_gor);
            k2.fakulte = "Tıp Fakultesi";
            Console.WriteLine();
            Console.WriteLine(k2.fakulte);
            Console.ReadKey();
        }
    }
}
