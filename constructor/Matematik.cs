using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace constructor
{
    public class Matematik
    {
        public int Topla(int sayi1, int sayi2)
        {
            int sonuc = 0;
            sonuc = sayi1 + sayi2;
            return sonuc;

        }

        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }

        public int Topla(int sayi1, int sayi2, int sayi3)
        {
            int sonuc = 0;
            sonuc = sayi1 + sayi2 + sayi3;
            return sonuc;
        }

        public int Carp(int sayi1, int sayi2, int sayi3)
        {
            return sayi1 * sayi2 * sayi3;
        }

    }
}
