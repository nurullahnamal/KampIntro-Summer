namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri = new GercekMusteri();
            musteri.Id = 1;
            musteri.MusteriNo = "212";
            musteri.Soyadi = "Yılmaz";
            musteri.Adi = "Ahmet";
            musteri.TcNo = "464164196449";

            //kodlama.io

            TuzelMusteri Tmusteri=new TuzelMusteri();
            Tmusteri.Id = 2;
            Tmusteri.MusteriNo = "444";
            Tmusteri.VergiNo = "7997496";
            Tmusteri.SirketAdi = "874646";


            Musteri musteri3= new GercekMusteri();
            Musteri musteri4= new TuzelMusteri();

            MusteriManager musteriManager=new MusteriManager();
            musteriManager.Add(musteri);

        }
    }
}