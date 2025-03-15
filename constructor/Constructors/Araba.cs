using constructor.Constructors;
using constructor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor.Constructors
{
    public class Araba
    {
        public Marka Marka;
        public Model Model;
        public Kapi Kapi;
        public Pencere Pencere;
        public Kasa Kasa;
        public Fiyat Fiyat;

        public Araba(Marka marka, Model model, Kapi kapi, Pencere pencere, Kasa kasa, Fiyat fiyat)
        {
            this.Marka = marka;
            this.Model = model;
            this.Kapi = kapi;
            this.Pencere = pencere;
            this.Kasa = kasa;
            this. Fiyat = fiyat;
        }

        
    }
}
