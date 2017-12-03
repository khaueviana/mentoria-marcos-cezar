using System;
using System.Windows.Forms;

namespace Banco
{
    public partial class FormCadastroConta : Form
    {
        private Form1 formPrincipal;

        public FormCadastroConta(Form1 formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
        }

        private void botaoCadastro_Click(object sender, EventArgs e)
        {
            ContaPoupanca novaConta = new ContaPoupanca();
            novaConta.Titular = new Cliente(textoTitular.Text);
            formPrincipal.AdicionaContas(novaConta);
        }

        private void FormCadastroConta_Load(object sender, EventArgs e)
        {
            textNumero.Text = Convert.ToString(ContaPoupanca.ProximaConta());
        }

        private void textNumero_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
