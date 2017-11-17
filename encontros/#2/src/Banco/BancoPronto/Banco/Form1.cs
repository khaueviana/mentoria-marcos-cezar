using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Banco.Contas;
namespace Banco
{
    public partial class Form1 : Form
    {
        private List<Conta> contas = new List<Conta>();
        private int numeroDeContas;

        public void AdicionaContas(Conta conta)
        {
            contas.Add(conta);
            this.numeroDeContas++;
            comboContas.Items.Add("titular: " + conta.Titular.Nome);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            Conta selecionada = this.contas[indice];

            string valorDigitado = textoValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);

            try
            {
                selecionada.Deposita(valorOperacao);
                textoSaldo.Text = Convert.ToString(selecionada.Saldo);
                MessageBox.Show("Operação realizada com sucesso");
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Não é possível depositar um valor negativo");
            }
            textoValor.Text = "";

        }

        private void botaoSaque_Click(object sender, EventArgs e)
        {

            int indice = comboContas.SelectedIndex;
            Conta selecionada = this.contas[indice];

            string valorDigitado = textoValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);
            try
            {
            selecionada.Saca(valorOperacao);
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
            MessageBox.Show("Operação realizada com sucesso");
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Não é possível sacar um valor negativo");
            }catch (SaldoInsuficienteException)
            {
                MessageBox.Show("Saldo insuficiente");

            }
            textoValor.Text = "";



        }

        private void BotaoDeBusca_Click(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            Conta selecionada = this.contas[indice];

            textoTitular.Text = selecionada.Titular.Nome;
            textoNumero.Text = Convert.ToString(selecionada.Numero);
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
            tiConta.Text = Convert.ToString(selecionada.Tipo());
        }

        private void bataoCadastro_Click(object sender, EventArgs e)
        {
            FormCadastroConta formularioCadastro = new FormCadastroConta(this,contas);
            formularioCadastro.ShowDialog();
        }

        private void botaoImpostos_Click(object sender, EventArgs e)
        {

            int indice = comboContas.SelectedIndex;
            Conta selecionada = this.contas[indice];
            TotalizadorDeTributos total = new TotalizadorDeTributos();


            if (selecionada is ContaPoupanca || selecionada is ContaInvestimento)
            {
                total.Acumula((ITributavel)selecionada);
                selecionada.Saca(1);
                MessageBox.Show("Foi!");
                MessageBox.Show("" + total.Total);
                textoSaldo.Text = Convert.ToString(selecionada.Saldo);
            }
            else
            {
                MessageBox.Show("Essa conta não precisa pagar impostos");
            }


        }


        private void botRel_Click(object sender, EventArgs e)
        {
            FormRelatorios form = new FormRelatorios(this.contas);
            form.ShowDialog();
        }

    }
}
