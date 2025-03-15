using constructor.Constructors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace constructor
{
    public class YeniAraba
    {
        public Araba Araba;
        
        public YeniAraba(Marka marka,Model model, Kapi kapi, Pencere pencere, Kasa kasa, Fiyat fiyat)
        {
            this.Araba = Araba;
        }

        public void Ozellikler()
        {
            Console.WriteLine("Arabanin markasi: " + Araba.Marka.markaAdi + " modeli: " + Araba.Model.modelAdi+
  
                " kapi sayisi: " + Araba.Kapi.sayi + " Pencere sayisi: " + Araba.Pencere.sayi + " Kasası: " + Araba.Kasa.kasaAdi + " fiyatı: " + Araba.Fiyat.fiyat);
        }
    }


     
     


}



