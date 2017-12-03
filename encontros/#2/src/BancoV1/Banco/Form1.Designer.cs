namespace Banco
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textoTitular = new System.Windows.Forms.TextBox();
            this.textoNumero = new System.Windows.Forms.TextBox();
            this.textoSaldo = new System.Windows.Forms.TextBox();
            this.textoValor = new System.Windows.Forms.TextBox();
            this.botaoDeposito = new System.Windows.Forms.Button();
            this.botaoSaque = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BotaoDeBusca = new System.Windows.Forms.Button();
            this.comboContas = new System.Windows.Forms.ComboBox();
            this.bataoCadastro = new System.Windows.Forms.Button();
            this.botaoImpostos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textoTitular
            // 
            this.textoTitular.Location = new System.Drawing.Point(274, 168);
            this.textoTitular.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textoTitular.Name = "textoTitular";
            this.textoTitular.Size = new System.Drawing.Size(148, 26);
            this.textoTitular.TabIndex = 0;
            // 
            // textoNumero
            // 
            this.textoNumero.Location = new System.Drawing.Point(274, 249);
            this.textoNumero.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textoNumero.Name = "textoNumero";
            this.textoNumero.Size = new System.Drawing.Size(148, 26);
            this.textoNumero.TabIndex = 1;
            // 
            // textoSaldo
            // 
            this.textoSaldo.Location = new System.Drawing.Point(274, 322);
            this.textoSaldo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textoSaldo.Name = "textoSaldo";
            this.textoSaldo.Size = new System.Drawing.Size(148, 26);
            this.textoSaldo.TabIndex = 2;
            // 
            // textoValor
            // 
            this.textoValor.Location = new System.Drawing.Point(274, 397);
            this.textoValor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textoValor.Name = "textoValor";
            this.textoValor.Size = new System.Drawing.Size(148, 26);
            this.textoValor.TabIndex = 3;
            // 
            // botaoDeposito
            // 
            this.botaoDeposito.Location = new System.Drawing.Point(114, 460);
            this.botaoDeposito.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.botaoDeposito.Name = "botaoDeposito";
            this.botaoDeposito.Size = new System.Drawing.Size(112, 42);
            this.botaoDeposito.TabIndex = 4;
            this.botaoDeposito.Text = "Deposita";
            this.botaoDeposito.UseVisualStyleBackColor = true;
            this.botaoDeposito.Click += new System.EventHandler(this.button1_Click);
            // 
            // botaoSaque
            // 
            this.botaoSaque.Location = new System.Drawing.Point(274, 460);
            this.botaoSaque.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.botaoSaque.Name = "botaoSaque";
            this.botaoSaque.Size = new System.Drawing.Size(112, 42);
            this.botaoSaque.TabIndex = 5;
            this.botaoSaque.Text = "Saca";
            this.botaoSaque.UseVisualStyleBackColor = true;
            this.botaoSaque.Click += new System.EventHandler(this.botaoSaque_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 168);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Titular";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 249);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Numero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 322);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Saldo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 402);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Valor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 42);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Escolha a Conta";
            // 
            // BotaoDeBusca
            // 
            this.BotaoDeBusca.Location = new System.Drawing.Point(195, 98);
            this.BotaoDeBusca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BotaoDeBusca.Name = "BotaoDeBusca";
            this.BotaoDeBusca.Size = new System.Drawing.Size(112, 42);
            this.BotaoDeBusca.TabIndex = 12;
            this.BotaoDeBusca.Text = "Buscar";
            this.BotaoDeBusca.UseVisualStyleBackColor = true;
            this.BotaoDeBusca.Click += new System.EventHandler(this.BotaoDeBusca_Click);
            // 
            // comboContas
            // 
            this.comboContas.FormattingEnabled = true;
            this.comboContas.Location = new System.Drawing.Point(274, 42);
            this.comboContas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboContas.Name = "comboContas";
            this.comboContas.Size = new System.Drawing.Size(180, 28);
            this.comboContas.TabIndex = 13;
            // 
            // bataoCadastro
            // 
            this.bataoCadastro.Location = new System.Drawing.Point(4, 511);
            this.bataoCadastro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bataoCadastro.Name = "bataoCadastro";
            this.bataoCadastro.Size = new System.Drawing.Size(112, 42);
            this.bataoCadastro.TabIndex = 14;
            this.bataoCadastro.Text = "Nova conta";
            this.bataoCadastro.UseVisualStyleBackColor = true;
            this.bataoCadastro.Click += new System.EventHandler(this.bataoCadastro_Click);
            // 
            // botaoImpostos
            // 
            this.botaoImpostos.Location = new System.Drawing.Point(362, 511);
            this.botaoImpostos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.botaoImpostos.Name = "botaoImpostos";
            this.botaoImpostos.Size = new System.Drawing.Size(112, 42);
            this.botaoImpostos.TabIndex = 15;
            this.botaoImpostos.Text = "Impostos";
            this.botaoImpostos.UseVisualStyleBackColor = true;
            this.botaoImpostos.Click += new System.EventHandler(this.botaoImpostos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 592);
            this.Controls.Add(this.botaoImpostos);
            this.Controls.Add(this.bataoCadastro);
            this.Controls.Add(this.comboContas);
            this.Controls.Add(this.BotaoDeBusca);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botaoSaque);
            this.Controls.Add(this.botaoDeposito);
            this.Controls.Add(this.textoValor);
            this.Controls.Add(this.textoSaldo);
            this.Controls.Add(this.textoNumero);
            this.Controls.Add(this.textoTitular);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textoTitular;
        private System.Windows.Forms.TextBox textoNumero;
        private System.Windows.Forms.TextBox textoSaldo;
        private System.Windows.Forms.TextBox textoValor;
        private System.Windows.Forms.Button botaoDeposito;
        private System.Windows.Forms.Button botaoSaque;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BotaoDeBusca;
        private System.Windows.Forms.ComboBox comboContas;
        private System.Windows.Forms.Button bataoCadastro;
        private System.Windows.Forms.Button botaoImpostos;
    }
}

