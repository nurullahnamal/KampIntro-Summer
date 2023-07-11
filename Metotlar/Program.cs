namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
           
            urun1.Id = "21";
            urun1.Adi = "elma";
            urun1.Fiyati = 222;
            urun1.Acıklama = "Elma Acıklama";
            urun1.StokAdedi = 33;



            Urun urun2 = new Urun();
            urun2.Id = "A21";
            urun2.Adi = "Armut";
            urun2.Fiyati = 212;
            urun2.Acıklama = "Armut Acıklama";
            urun2.StokAdedi = 33;


            //BURADA URUNLERI TEK SEFER DE YAZDIRABILIRSIN OTOMASYONU DAHA KOLAY OLUR
            /* 
            Urun[] metotlar = new Urun[] { urun1, urun2 };

            foreach (var item in metotlar)
            {
                Console.WriteLine(item.Id.ToString() + "  : " + item.Adi + "  : " + item.Fiyati + "  : " + item.Fiyati);
            }
            */

            ////  ASAGIDA KI ORNEGE GORE YAPARSAK URUNLERI ISIMLERINE GORE  TEKER TEKER  YAZMAK GEREKIR 
            
            
            Console.WriteLine("------------------------------------------------------");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            

        }
    }
}