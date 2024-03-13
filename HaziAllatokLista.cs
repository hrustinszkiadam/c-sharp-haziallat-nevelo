namespace haziallat_nevelo
{
    class HaziAllatokLista
    {
        public List<HaziAllat> Allatok { get; set; }

        public HaziAllatokLista(List<HaziAllat>? allatok = null)
        {
            Allatok = allatok ?? new List<HaziAllat>();
        }

        public void AllatHozzaad(HaziAllat allat)
        {
            Allatok.Add(allat);
        }

        public void AllatokListaz()
        {
            foreach(var allat in Allatok)
            {
                allat.AllatInfo();
            }
        }
    }
}
