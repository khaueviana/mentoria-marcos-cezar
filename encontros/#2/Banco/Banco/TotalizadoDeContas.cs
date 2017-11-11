using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class TotalizadoDeContas
    {
        public double ValorTotal { get; private set; }
        //Aqui se utilizou os conhecimentos sobre polimorfismo
        public void Soma(Conta conta)
        {
            this.ValorTotal = conta.Saldo;
        }

    }
}
