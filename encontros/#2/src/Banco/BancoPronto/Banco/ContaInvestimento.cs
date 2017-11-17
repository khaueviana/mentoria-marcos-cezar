using System;

namespace Banco.Contas
{
    class ContaInvestimento : Conta, ITributavel
    {
        public override void Saca(double valorOperacao)
        {
            if (valorOperacao < 0)
            {
                throw new ArgumentException();

            }

            else if (valorOperacao > Saldo)
            {
                throw new SaldoInsuficienteException();
            }
            else
            {

                this.Saldo -= valorOperacao+2;
            }
        }
        public override void Deposita(double valorOperacao)
        {
            if (valorOperacao < 0)
            {
                throw new ArgumentException();
            }

            else
            {

                this.Saldo += valorOperacao-1;
            }

        }

        public double CalculaTributos()
        {
            return this.Saldo * 0.03;
        }
        public override string Tipo() => "Conta Investimento";
    }
}
