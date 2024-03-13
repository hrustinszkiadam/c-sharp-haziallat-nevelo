namespace haziallat_nevelo
{
    class Program
    {
        static void Main(string[] args)
        {
            HaziAllatokLista allatok = new HaziAllatokLista();

            Kutya Rex = new Kutya("Rex");
            allatok.AllatHozzaad(Rex);
            Rex.AllatInfo();
            Rex.Seta();
            Rex.Apport();
            Rex.AllatInfo();

            Macska Mia = new Macska("Mia");
            allatok.AllatHozzaad(Mia);
            Mia.AllatInfo();
            Mia.Jatszadozas();
            Mia.Karmolas();
            Mia.AllatInfo();

            Nyul Hops = new Nyul("Hops");
            allatok.AllatHozzaad(Hops);
            Hops.AllatInfo();
            Hops.Kaparaszas();
            Hops.Ugras();
            Hops.AllatInfo();

            Madar Chirpy = new Madar("Chirpy");
            allatok.AllatHozzaad(Chirpy);
            Chirpy.AllatInfo();
            Chirpy.Repules();
            Chirpy.Dalolas();
            Chirpy.AllatInfo();

            allatok.AllatokListaz();

            Console.ReadKey();
        }
    }
}
