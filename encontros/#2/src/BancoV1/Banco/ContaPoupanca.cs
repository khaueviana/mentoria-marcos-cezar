namespace Banco
{
    public class ContaPoupanca : Conta, ITributavel
    {
        public static int TotalDeContas;

        public override void Saca(double valorOperacao) => Saldo -= valorOperacao + 0.05;
        public override void Deposita(double valorOperacao) => Saldo += valorOperacao - 0.10;

        public ContaPoupanca()
        {
            ContaPoupanca.TotalDeContas++;
            Numero = TotalDeContas;
        }

        public static int ProximaConta()
        {
            return ContaPoupanca.TotalDeContas + 1;
        }

        public double CalculaTributos()
        {
            return Saldo * 0.02;
        }
    }
}