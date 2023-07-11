using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
     class Islemelr
    {
        public void Toplama(int sayi1,int sayi2)
        {
            int Sonuc = sayi1 + sayi2;
            Console.WriteLine("sonuc : "+Sonuc);
        }
        public void cıkarma(int sayi1, int sayi2)
        {
            int Sonuc = sayi1 - sayi2;
            Console.WriteLine("sonuc : " + Sonuc);
        }
        public void Bolme(int sayi1, int sayi2)
        {
            int Sonuc = sayi1 / sayi2;
            Console.WriteLine("sonuc : " + Sonuc);
        }
        public void Carpma(int sayi1, int sayi2)
        {
            int Sonuc = sayi1 * sayi2;
            Console.WriteLine("sonuc : " + Sonuc);
        }

    }
}
