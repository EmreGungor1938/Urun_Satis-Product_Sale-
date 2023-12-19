using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urun_Satis_Product_Sale_
{
    class Program
    {

        static int brc;   //Genel(Global)değişken
        static void Main(string[] args)
        {
            string urunadi;
            int fiyat, miktar, borc, odeme;

            Console.WriteLine("Ürün adi giriniz: ");
            urunadi = Console.ReadLine();

            Console.WriteLine("Fiyati giriniz: ");
            fiyat = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Miktar Giriniz: ");
            miktar = Convert.ToInt32(Console.ReadLine());

            borc = fiyat * miktar;

            hsp(fiyat, miktar);

            Console.WriteLine("Odeme Giriniz: ");
            odeme = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(paraustu(odeme));
         

            Console.Write("Ürün adınız {2}, borcunuz {0} TL, {3} TL ödeme yaptınız, paraüstünüz {1} TL.", brc, paraustu(odeme), urunadi, odeme);
        }
        static void hsp(int fyt, int mkt)   // PARAMETRELİ PROCEDURE (GERİYE DEĞER DÖNDÜRMEYEN VOID METOD)
        {
            brc = fyt * mkt;
        }
        static int paraustu(int odm)    // PARAMETRELİ FUNCTION (GERİYE DEĞER DÖNDÜREN METOD) 
        {
            return odm - brc;
            Console.ReadLine();
        }
        
    }

}
