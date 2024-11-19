namespace Tim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tim1 tim1 = new Tim1 ("Jozo");
            Tim1 tim2 = new Tim1("Dano");
            Tim1 tim3 = new Tim1("Stevo");

            Console.WriteLine("Celkovy pocet timov :" + Tim1.ZiskajPocettimov());
        }
    }
}