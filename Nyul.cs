namespace haziallat_nevelo
{
    class Nyul : HaziAllat
    {
        public Nyul(string nev) : base(nev) { }

        public void Kaparaszas()
        {
            if(Egeszseg < 10)
            {
                Console.WriteLine("Nincs elég egészség a kaparászáshoz!");
                return;
            }

            Hangulat += 10;
            Egeszseg -= 5;
        }

        public void Ugras()
        {
            if(Energia < 10)
            {
                Console.WriteLine("Nincs elég energia az ugráshoz!");
                return;
            }

            Hangulat += 15;
            Energia -= 10;
        }
    }
}
