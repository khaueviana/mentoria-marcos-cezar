using System;

namespace Banco.Contas
{
    class ContaCorrente : Conta
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

                this.Saldo -= valorOperacao;
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

                this.Saldo += valorOperacao;
            }

        }

        public override string Tipo() => "Conta Corrente";
    }
}
