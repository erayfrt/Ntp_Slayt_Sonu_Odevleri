﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slayt6._5
{
    internal class Program
    {
        struct Ogrenci
        {
            public int Numara;
            public String Ad;
            public String Soyad;

        }
        static void Main(string[] args)
        {
            Ogrenci ogr1 = new Ogrenci();
            ogr1.Numara = 10;
            ogr1.Ad = "Ali";
            ogr1.Soyad = "Türk";

            Ogrenci ogr2 = new Ogrenci();

            ogr2.Numara = 20;

            Console.WriteLine("{0} {1} {2}", ogr1.Numara, ogr1.Ad, ogr1.Soyad);
            Console.WriteLine("{0}{1}{2}", ogr2.Numara, ogr2.Ad, ogr2.Soyad);
            Console.ReadKey();
        }
    }
}
