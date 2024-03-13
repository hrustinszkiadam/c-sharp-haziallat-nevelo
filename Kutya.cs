namespace haziallat_nevelo
{
    class Kutya : HaziAllat
    {
        public Kutya(string nev) : base(nev) { }

        public void Seta()
        {
            Hangulat += 15;
            Egeszseg += 10;
            Energia -= 20;
        }

        public void Apport()
        {
            Energia += 10;
            Egeszseg += 5;
            Ehesseg -= 5;
        }
    }
}
