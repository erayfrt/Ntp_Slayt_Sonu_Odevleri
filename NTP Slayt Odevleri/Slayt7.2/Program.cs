using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace isimalan1
{
    class Deneme
    {
        public Deneme()
        {
            Console.WriteLine("Deneme 1");
        }
    }
}

namespace Slayt7._2

{
    class Deneme
    {
        public Deneme()
        {
            Console.WriteLine("Deneme 2");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            isimalan1.Deneme d1 = new isimalan1.Deneme();
            Slayt7._2.Deneme d2 = new Slayt7._2.Deneme();
            Console.ReadKey();
        }
    }
}
