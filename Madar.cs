namespace haziallat_nevelo
{
    class Madar : HaziAllat
    {
        public Madar(string nev) : base(nev) { }

        public void Repules()
        {
            if(Energia < 40)
            {
                Console.WriteLine("Nincs elég energia a repüléshez!");
                return;
            }

            Hangulat += 30;
            Egeszseg += 15;
            Energia -= 40;
        }

        public void Dalolas()
        {
            Hangulat += 10;
            Egeszseg += 5;
        }
    }
}
