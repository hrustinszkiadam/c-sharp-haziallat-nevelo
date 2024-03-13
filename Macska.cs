namespace haziallat_nevelo
{
    class Macska : HaziAllat
    {
        public Macska(string nev) : base(nev) { }

        public void Jatszadozas()
        {
            Hangulat += 20;
            Energia -= 25;
        }

        public void Karmolas()
        {
            Egeszseg += 5;
            Hangulat -= 10;
        }
    }
}
