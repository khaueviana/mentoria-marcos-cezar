namespace Banco
{
    public class ContaCorrente : Conta
    {
        public override void Deposita(double valorOperacao)
        {
            Saldo += valorOperacao;
        }

        public override void Saca(double valorOperacao)
        {
            Saldo -= valorOperacao;
        }
    }
}