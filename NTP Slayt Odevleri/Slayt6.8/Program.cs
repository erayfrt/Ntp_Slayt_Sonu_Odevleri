using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slayt6._8
{
    enum Gunler : byte
    {
        Pazartesi, Salı, Carsamba, Persembe, Cuma, Cumartesi, Pazar
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((int)Gunler.Pazartesi);
            Console.WriteLine((int)Gunler.Pazar);
            Console.ReadKey();
        }
    }
}
