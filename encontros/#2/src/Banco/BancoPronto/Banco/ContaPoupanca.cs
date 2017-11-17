using System;

namespace Banco.Contas
{

    public class ContaPoupanca : Conta, ITributavel
    {
        static int TotalDeContas = 0;
        public override void Saca(double valorOperacao)
        {
            if(valorOperacao < 0)
            {
                throw new ArgumentException();

            }

            else if(valorOperacao > Saldo)
            {
                throw new SaldoInsuficienteException();
            }
            else
            {
                
                this.Saldo -= valorOperacao + 0.05;
            }
        }
        public override void Deposita(double valorOperacao) {
            if(valorOperacao < 0)
            {
                throw new ArgumentException();
            }

            else
            {

            this.Saldo += valorOperacao - 0.10;
            }

        }

        public ContaPoupanca()
        {
            ContaPoupanca.TotalDeContas++;
            this.Numero = TotalDeContas;
        }
        public double CalculaTributos()
        {
            return this.Saldo * 0.02;
        }
        public override string Tipo() => "Conta Poupança";
    }

}