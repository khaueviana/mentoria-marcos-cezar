using System;
using System.Collections.Generic;
using Banco.Contas;
using System.Windows.Forms;
using System.Linq;

namespace Banco
{
    public partial class FormRelatorios : Form
    {
        private List<Conta> contas;
        public FormRelatorios(List<Conta> contas)
        {
            InitializeComponent();
            this.contas = contas;
        }

        private void botaoFiltraSaldo_Click(object sender, EventArgs e)
        {
            listResultado.Items.Clear();
            var resultado = contas.Where(c => c.Saldo > 200);
            foreach (var c in resultado)
            {
                listResultado.Items.Add(c);
            }
        }
    }
}
