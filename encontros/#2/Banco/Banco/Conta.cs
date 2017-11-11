using System;
using System.ComponentModel;

namespace Banco
{
    public abstract class Conta : Container
    {
        public int Numero { get; set; }
        public double Saldo { get; protected set; }
        public Cliente Titular { get; set; }
        


        /*
        public Conta (int numero)
        {
            this.Numero = numero;

        }*/


        public abstract void Deposita(double valorOperacao);

        public abstract void Saca(double valorOperacao);
    }
}