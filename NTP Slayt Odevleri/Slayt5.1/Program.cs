﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slayt5._1
{
    internal class Program
    {
        static float Fonksiyon(float x)
        {
            return 2 * x + 5;
        }
       
        static float TersFonksiyon(float x)
        {
            return (x - 5) / 2;
        }
        static void Main(string[] args)
        {
            float x=10;
            Console.WriteLine(Fonksiyon(x));
            Console.WriteLine(TersFonksiyon(x));
            Console.WriteLine(Fonksiyon(TersFonksiyon(x)));

            Console.ReadKey();
        }
    }
}
