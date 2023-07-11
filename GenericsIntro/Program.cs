namespace GenericsIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("dwad");
            isimler.Add("wadwa");
            foreach (var item in isimler.Items)
            {
                Console.WriteLine(item);
            }

        }
    }
}