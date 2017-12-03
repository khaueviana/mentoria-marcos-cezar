namespace Banco
{
    public class ContaInvestimento : Conta, ITributavel
    {
        public override void Deposita(double valorOperacao)
        {
            Saldo += valorOperacao;
        }

        public override void Saca(double valorOperacao)
        {
            Saldo -= valorOperacao;
        }

        public double CalculaTributos()
        {
            return Saldo * 0.03;
        }
    }
}