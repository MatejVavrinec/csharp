namespace Knihy
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Kniha kniha1 = new Kniha("Harry Potter", 500);

            kniha1.Nazov = "Harry Potter";
            kniha1.Pocetstran = 285;
            Console.WriteLine($"Meno knihy je {kniha1.Nazov} a pocet stran je {kniha1.Pocetstran}");
        }

        
    }
}