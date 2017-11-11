using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class Form1 : Form
    {
        private ContaPoupanca[] contas;
        private int numeroDeContas;

        public void AdicionaContas(ContaPoupanca conta)
        {
            this.contas[this.numeroDeContas] = conta;
            this.numeroDeContas++;
            comboContas.Items.Add("titular: " + conta.Titular.Nome);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            contas = new ContaPoupanca[3];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            Conta selecionada = this.contas[indice];

            string valorDigitado = textoValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);
            selecionada.Deposita(valorOperacao);
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
            MessageBox.Show("Operação realizada com sucesso");

        }

        private void botaoSaque_Click(object sender, EventArgs e)
        {

            int indice = comboContas.SelectedIndex;
            Conta selecionada = this.contas[indice];

            string valorDigitado = textoValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);
            selecionada.Saca(valorOperacao);
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
            MessageBox.Show("Operação realizada com sucesso");
            


            /*
            Conta[] contas = new Conta[5];
            contas[0] = new Conta() { Numero = 1 };
            contas[1] = new ContaPoupanca() { Numero = 2 };
            contas[2] = new Conta() { Numero = 3 };
            contas[3] = new ContaPoupanca() { Numero = 4 };
            contas[4] = new Conta() { Numero = 5 };
            */
            /*
            for (int i = 0; i < contas.Length; i++)
            {
                MessageBox.Show(" " + contas[i].Numero);
            }
            */
            /*
            foreach (Conta conta in contas)
            {
                MessageBox.Show(" "+ conta.Numero);
            }
            */




        }



        private void BotaoDeBusca_Click(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            ContaPoupanca selecionada = this.contas[indice];

            textoTitular.Text = selecionada.Titular.Nome;
            textoNumero.Text = Convert.ToString(selecionada.Numero);
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
        }

        private void bataoCadastro_Click(object sender, EventArgs e)
        {
            FormCadastroConta formularioCadastro = new FormCadastroConta(this);
            formularioCadastro.ShowDialog();
        }

        private void botaoImpostos_Click(object sender, EventArgs e)
        {

            int indice = comboContas.SelectedIndex;
            ContaPoupanca selecionada = this.contas[indice];
            TotalizadorDeTributos total = new TotalizadorDeTributos();


            if (selecionada is ContaPoupanca)
            {
                total.Acumula(selecionada);
                selecionada.Saca(1);
                MessageBox.Show("Foi!");
                MessageBox.Show("" + total.Total);
                textoSaldo.Text = Convert.ToString(selecionada.Saldo);
            }
 



        }

        private void textoTitular_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
