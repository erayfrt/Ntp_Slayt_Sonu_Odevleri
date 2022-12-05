using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slayt6._9
{
    enum Gunler : byte
    {
        Pazartesi, Salı, Carsamba, Persembe, Cuma, Cumartesi, Pazar
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] sabitler =Enum.GetNames(typeof(Gunler));
            foreach(string s in sabitler)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }
    }
}
