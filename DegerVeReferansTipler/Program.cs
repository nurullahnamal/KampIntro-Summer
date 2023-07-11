namespace DegerVeReferansTipler
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] sayilar1=new int[] { 1, 2, 3 };
            int[] sayilar2=new int[] {11, 22, 33 };
            sayilar1 = sayilar2;
            sayilar2[0] = 1000;
            


            Console.WriteLine(sayilar1[0].ToString());
        }
    }
}