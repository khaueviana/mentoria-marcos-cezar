namespace Banco
{
    public class ContaPoupanca : Conta, ITributavel
    {
        public static int TotalDeContas;

        //public ContaPoupanca (int numero) : base (numero) { }

        public override void Saca(double valorOperacao) => this.Saldo -= valorOperacao + 0.05;
        public override void Deposita(double valorOperacao) => this.Saldo += valorOperacao - 0.10;

        public ContaPoupanca()
        {
            ContaPoupanca.TotalDeContas++;
            this.Numero = TotalDeContas;
        }


        public static int ProximaConta()
        {
            return ContaPoupanca.TotalDeContas + 1;
        }
        public double CalculaTributos()
        {
            return this.Saldo * 0.02;
        }
    }

}