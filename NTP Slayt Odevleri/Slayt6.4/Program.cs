﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slayt6._4
{
    class indexleyici
    {
        public double rakam;
        public double this[double index]
        {
            get
            {
                return Math.Pow(index, 2);
            }
            set { rakam = value; }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            indexleyici i = new indexleyici();
            Console.WriteLine("i[3.4]={0}", i[3.4]);
            i[10] = 10;
            Console.WriteLine(i.rakam);
            i[10] = 15;
            Console.WriteLine(i.rakam);
            Console.WriteLine("i[10]={0}", i[10]);
            Console.ReadKey();
        }
    }
}
