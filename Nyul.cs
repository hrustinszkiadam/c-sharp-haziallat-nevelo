namespace haziallat_nevelo
{
    class Nyul : HaziAllat
    {
        public Nyul(string nev) : base(nev) { }

        public void Kaparaszas()
        {
            Hangulat += 10;
            Egeszseg -= 5;
        }

        public void Ugras()
        {
            Hangulat += 15;
            Energia -= 10;
        }
    }
}
