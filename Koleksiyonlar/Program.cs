namespace Koleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*  
              string diziler boş iş ekstradan değer ataması yapamıyorsunuz

             string[] isimler = new string[] { "dawdw", "ddd" };
             Console.WriteLine(isimler[0]);
             isimler = new string[] { "ilker" }; // değeri ekleyemedik
            Console.WriteLine(isimler[2]);  ekleyemediği içinde veriyi çekemedik

            */

            // list Adamdır Çünkü sonradan veri ekleme işi çok kolay
            List<string> isimler2 = new List<string> { "Murat", "Halil", "Furkan" };
            isimler2.Add("4. yeni değer");
            Console.WriteLine(isimler2[3]);

            List<int> isimler3 = new List<int> { 1, 2, 3 };
            isimler3.Add(4);
            Console.WriteLine(isimler3[3]);
        }
    }
}