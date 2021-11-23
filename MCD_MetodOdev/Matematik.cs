using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_MetodOdev
{
    class Matematik
    {
        public decimal Toplama(decimal sayi1 , decimal sayi2)
        {
            decimal sonuc = sayi1 + sayi2;
            return sonuc;
           

        }
         public decimal Cıkarma(decimal sayi1,decimal sayi2)
        {
            decimal sonuc = sayi1 - sayi2;
            return sonuc;
            
        }
        
        public decimal Carpma(decimal sayi1,decimal sayi2)
        {
            decimal sonuc = sayi1 * sayi2;
            return sonuc;
            
        }
        
        public decimal Bolme(decimal sayi1,decimal sayi2)
        {
            decimal sonuc = sayi1 / sayi2;
            return sonuc;
            
        }

        public void menuHazirla()
        {
            Console.Clear();
            Console.WriteLine("****Menü****");
            Console.WriteLine("1 - Toplama");
            Console.WriteLine("2 - Çıkarma");
            Console.WriteLine("3 - Çarpma");
            Console.WriteLine("4 - Bölme");
            Console.WriteLine("Lütfen bir değer seçiniz.");
        }

        public void sonucEkranaYaz(decimal Sayi1,decimal Sayi2,decimal sonuc,string operators)
        {
            Console.WriteLine("{0} {1} {2} = {3} ",Sayi1,operators,Sayi2,sonuc);
        }
    }
}
