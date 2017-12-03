using System;
using System.Windows.Forms;

namespace Banco
{
    public partial class Form1 : Form
    {
        private Conta[] contas;
        private int numeroDeContas;

        public void AdicionaContas(Conta conta)
        {
            contas[numeroDeContas] = conta;
            numeroDeContas++;
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
            Conta selecionada = contas[indice];

            string valorDigitado = textoValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);
            selecionada.Deposita(valorOperacao);
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);

            MessageBox.Show("Operação realizada com sucesso");
        }

        private void botaoSaque_Click(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            Conta selecionada = contas[indice];

            string valorDigitado = textoValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);
            selecionada.Saca(valorOperacao);
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);

            MessageBox.Show("Operação realizada com sucesso");
        }

        private void BotaoDeBusca_Click(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            Conta selecionada = contas[indice];

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
            Conta selecionada = contas[indice];
            TotalizadorDeTributos total = new TotalizadorDeTributos();
            
            if (selecionada is ContaPoupanca)
            {
                total.Acumula((ITributavel)selecionada);
                selecionada.Saca(1);
                MessageBox.Show("Foi!");
                MessageBox.Show("" + total.Total);
                textoSaldo.Text = Convert.ToString(selecionada.Saldo);
            }
        }
    }
}