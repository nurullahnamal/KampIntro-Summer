namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasıtKrediManager = new TasıtKrediManager();
            IKrediManager konutKredisiManager = new KonutKredisiManager();

          
            
            ILoggerService databeseLoggerService=new DatabaseLoggerService();
            ILoggerService fileLoggerService=new FileLoggerService();
            ILoggerService smsLoggerService=new SmsLoggerService();
          


            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKrediManager(),smsLoggerService);



            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,tasıtKrediManager ,konutKredisiManager};

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}