using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_MetodOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            #region

            /*
             * Matematik adında bir class oluşturun.
             * Bir menü hazırlayın metod ile
             * Menüde
             * "****Menü****"
             * "1 - Toplama"
             * "2 - Çıkartma"
             * "3 - Çarpma"
             * "4 - Bölme"
             * "Lütfen bir değer seçiniz: "
             * Metod ile 4 işlemleri ekrana yazdır metot ile yazdırılacak.
             * public static void içinde matematik sınıfının bir instance'ini 
             * al, kullanıcıdan iki değer iste
             *ve matematik sınıfındaki 4 işlem metodunu kullanarak
             *sonuçları ekrana yazdır.switch case olabilir.
             *yeni işlem yapmak istiyor mu sor.(E/H)
             *
             */
            Matematik m= new Matematik();
            yenidenIslemYap:
            m.menuHazirla();

            
            string secim = Console.ReadLine();
            Console.WriteLine("Lütfen 1. sayıyı giriniz:");
            decimal sayi1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Lütfen 2. sayıyı giriniz:");
            decimal sayi2 = Convert.ToDecimal(Console.ReadLine());

            decimal sonuc = 0;

            switch (secim)
            {
                case "1": //toplama
                    sonuc = m.Toplama(sayi1, sayi2);
                    m.sonucEkranaYaz(sayi1, sayi2, sonuc, "+");
                    break;

                case "2": //çıkarma
                    sonuc = m.Cıkarma(sayi1, sayi2);
                    m.sonucEkranaYaz(sayi1, sayi2, sonuc, "-");
                    break;

                case "3": //çarpma
                    sonuc = m.Carpma(sayi1, sayi2);
                    m.sonucEkranaYaz(sayi1, sayi2, sonuc, "*");
                    break;

                case "4": //toplama
                    sonuc = m.Bolme(sayi1, sayi2);
                    m.sonucEkranaYaz(sayi1, sayi2, sonuc, "/");
                    break;


                default:
                    Console.WriteLine("Belirtmiş olduğunuz değer liste içerisinde bulunamadı.");
                    Console.WriteLine("Lütfen tekrar deneyiniz.");
                    System.Threading.Thread.Sleep(2000);
                    goto yenidenIslemYap;
            }

            Console.WriteLine("Yeni bir işlem yapmak istiyor musunuz? (E/H)");
            string eh = Console.ReadLine();
            if (eh=="e")
            {
                goto yenidenIslemYap;
            }
            


            Console.ReadLine();
            #endregion
        }
    }
}
