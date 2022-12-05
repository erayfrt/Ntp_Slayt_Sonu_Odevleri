using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slayt9._1
{
    class oto
    {
        protected double boy = 5;
        protected double agirlik = 800;
        protected string renk = "Sari";
        public void goster()
        {
            Console.WriteLine("Boy=" + boy);
            Console.WriteLine("Ağırlık=" + agirlik);
            Console.WriteLine("Renk=" + renk);
        }
    }
    class model1 : oto
    {
        public string tur;
        public int silindir_sayisi;
        public int subap_sayisi;
        public int tork;
        public int guc;
        public void ozellikyaz()
        {
            Console.WriteLine("Tür=" + tur);
            Console.WriteLine("Boy=" + boy);
            Console.WriteLine("Ağırlık=" + agirlik);
            Console.WriteLine("Renk=" + renk);
            Console.WriteLine("Silindir Sayisi=" + silindir_sayisi);
            Console.WriteLine("Subap Sayısı=" + subap_sayisi);
            Console.WriteLine("Tork=" + tork);
            Console.WriteLine("Güç=" + guc);
        }
    }
    class model2 : oto
    {
        public double model2_boy
        {
            get { return boy; }
            set { boy = value; }
        }
        public double model2_agirlik
        {
            get { return agirlik; }
            set { agirlik = value; }
        }
        public string model2_renk
        {
            get { return renk; }
            set { renk = value; }
        }
        public string tur = "Hatchback";
        public int silindir_sayisi = 8;
        public int subap_sayisi = 16;
        public int tork = 300;
        public int guc = 210;
        public void ozellikyaz()
        {
            Console.WriteLine("Tür=" + tur);
            Console.WriteLine("Boy=" + model2_boy);
            Console.WriteLine("Ağırlık=" + model2_agirlik);
            Console.WriteLine("Renk=" + model2_renk);
            Console.WriteLine("Silindir Sayisi=" + silindir_sayisi);
            Console.WriteLine("Subap Sayısı=" + subap_sayisi);
            Console.WriteLine("Tork=" + tork);
            Console.WriteLine("Güç=" + guc);
        }
    }
}
