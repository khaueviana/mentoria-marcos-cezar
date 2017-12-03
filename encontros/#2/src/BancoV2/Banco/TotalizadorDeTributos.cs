namespace Banco
{
    class TotalizadorDeTributos
    {

        public double Total { get; set; }
        
        public void Acumula (ITributavel t)
        {
            this.Total += t.CalculaTributos();
        }

    }
}
