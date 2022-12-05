using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slayt6._6
{
    enum notu : byte { basarisiz, basarili }
    internal class Program
    {
        static void Main(string[] args)
        {
            notu a = notu.basarili;
            if (a == (notu)1)
                Console.Write("Başarılısınız");
            else
                Console.Write("Başarısızsınız");
            Console.ReadKey();
        }
    }
}
