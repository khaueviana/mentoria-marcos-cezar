using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Banco.Contas;

namespace Banco
{
    public partial class FormCadastroConta : Form
    {
        Conta[] contas = new Conta[3] {new ContaPoupanca(), new ContaCorrente(), new ContaInvestimento()};

        private List<Conta> Cot;
        private Form1 formPrincipal;

        public FormCadastroConta(Form1 formPrincipal, List<Conta> contas)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
            Cot = contas;
            
        }

        public Conta[] Contas { get => contas; set => contas = value; }

        private void botaoCadastro_Click(object sender, EventArgs e)
        {
            int indice = comboTipos.SelectedIndex;
            Conta novaConta = Contas[indice];
            novaConta.Titular = new Cliente(textoTitular.Text);
            this.formPrincipal.AdicionaContas(novaConta);
            this.Close();

        }

        private void FormCadastroConta_Load(object sender, EventArgs e)
        {
            textNumero.Text = Convert.ToString(Cot.Count +1);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
