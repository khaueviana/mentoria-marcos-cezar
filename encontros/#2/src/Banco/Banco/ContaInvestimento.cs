using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class ContaInvestimento : Conta, ITributavel
    {
        public override void Deposita(double valorOperacao)
        {
            this.Saldo += valorOperacao;
        }

        public override void Saca(double valorOperacao)
        {
            this.Saldo -= valorOperacao;
        }

        public double CalculaTributos()
        {
            return this.Saldo * 0.03;
        }

    }
}
