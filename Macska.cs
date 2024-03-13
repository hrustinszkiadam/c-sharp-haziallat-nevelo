namespace haziallat_nevelo
{
    class Macska : HaziAllat
    {
        public Macska(string nev) : base(nev) { }

        public void Jatszadozas()
        {
            if(Energia < 25)
            {
                Console.WriteLine("Nincs elég energia a játszadozáshoz!");
                return;
            }

            Hangulat += 20;
            Energia -= 25;
        }

        public void Karmolas()
        {
            if(Hangulat < 10)
            {
                Console.WriteLine("Nincs elég hangulat a karmoláshoz!");
                return;
            }

            Egeszseg += 5;
            Hangulat -= 10;
        }
    }
}
