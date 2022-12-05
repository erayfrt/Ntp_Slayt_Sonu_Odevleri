using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slayt9._6
{
    internal class oto
    {
        protected double motorgucu = 5;
        protected double tork = 800;
        protected string renk = "Sari";
        public oto(double guc,double tork,string renk) { 
            this.motorgucu = guc;
            this.tork = tork;
            this.renk = renk;  
        }
        public void ozellikgoster()
        {
            Console.WriteLine("Motor Gücü=" + motorgucu);
            Console.WriteLine("Tork=" + tork);
            Console.WriteLine("Renk=" + renk);
        }
        public double MotorGucu
        {
            get { return motorgucu; }
            set { motorgucu = value;}
        }
        public double Tork
        {
            get { return tork; }
            set { tork = value;}
        }
        public string Renk
        {
            get { return renk; }
            set
            {
                renk = value;
            }
        }
    }
    class model1 : oto
    {
        public string Tur;
        public model1(string tur,double guc,double tork,
            string renk):base(guc,tork,renk)
        {
            this.Tur = tur;
        }
        public void TurGoster()
        {
            Console.WriteLine("Türü" + Tur);
        }
    }
    class model2 : oto
    {
        public string Tur;
        public model2(string tur,double guc,double tork,
            string renk):base(guc,tork,renk)
        {
            this.Tur = tur;
        }
        public void TurGoster()
        {
            Console.WriteLine("Türü" + Tur);
        }
    }
}
