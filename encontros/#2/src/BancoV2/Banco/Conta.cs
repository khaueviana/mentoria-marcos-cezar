using System;

namespace Banco.Contas
{

    public class SaldoInsuficienteException : Exception
    {
    }
    public abstract class Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; protected set; }
        public Cliente Titular { get; set; }

        public override string ToString()
        {
            return Titular.Nome;
        }
        public abstract string Tipo();
        public abstract void Deposita(double valorOperacao);

        public abstract void Saca(double valorOperacao);
    }
}