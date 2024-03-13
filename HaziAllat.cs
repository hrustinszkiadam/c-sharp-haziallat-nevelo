namespace haziallat_nevelo
{
    class HaziAllat
    {
        public string Nev { get; set; }

        private void CheckValue(ref int value)
        {
            if (value < 0) value = 0;
            else if (value > 100) value = 100;
        }

        private int egeszseg;
        public int Egeszseg
        {
            get => egeszseg;
            set
            {
                CheckValue(ref value);
                egeszseg = value;
            }
        }

        private int hangulat;
        public int Hangulat
        {
            get => hangulat;
            set
            {
                CheckValue(ref value);
                hangulat = value;
            }
        }

        private int energia;
        public int Energia
        {
            get => energia;
            set
            {
                CheckValue(ref value);
                energia = value;
            }
        }

        private int ehesseg;
        public int Ehesseg
        {
            get => ehesseg;
            set
            {
                CheckValue(ref value);
                ehesseg = value;
            }
        }

        public HaziAllat(string nev)
        {
            Nev = nev;
            Egeszseg = 50;
            Hangulat = 50;
            Energia = 50;
            Ehesseg = 50;
        }

        public void EtelAdas()
        {
            if(Ehesseg < 10) {
                Console.WriteLine("Nem éhes!");
                return;
            }

            Ehesseg -= 10;
            Egeszseg += 5;
        }

        public void Jatek()
        {
            if (Energia < 10)
            {
                Console.WriteLine("Nincs elég energia a játékhoz!");
                return;
            }

            Hangulat += 10;
            Energia -= 10;
            Ehesseg += 10;
        }

        public void Pihenes()
        {
            if (Hangulat < 10)
            {
                Console.WriteLine("Nincs elég hangulat a pihenéshez!");
                return;
            }

            Energia += 10;
            Hangulat -= 10;
        }

        public void OrvoshozMegy()
        {
            if(Hangulat < 10)
            {
                Console.WriteLine("Nincs elég hangulat az orvoshoz menethez!");
                return;
            }

            Egeszseg += 10;
            Hangulat -= 10;
        }

        public override string ToString()
        {
            return $"{Nev}\nEgészség: {Egeszseg}\nHangulat: {Hangulat}\nEnergia: {Energia}\nÉhesseg: {Ehesseg}";
        }

        public void AllatInfo()
        {
            Console.WriteLine(this);
            Console.WriteLine();
        }
    }
}
