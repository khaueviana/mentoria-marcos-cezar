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
            this.botRel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tiConta = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textoTitular
            // 
            this.textoTitular.Location = new System.Drawing.Point(149, 29);
            this.textoTitular.Name = "textoTitular";
            this.textoTitular.Size = new System.Drawing.Size(100, 20);
            this.textoTitular.TabIndex = 0;
            // 
            // textoNumero
            // 
            this.textoNumero.Location = new System.Drawing.Point(147, 66);
            this.textoNumero.Name = "textoNumero";
            this.textoNumero.Size = new System.Drawing.Size(100, 20);
            this.textoNumero.TabIndex = 1;
            // 
            // textoSaldo
            // 
            this.textoSaldo.Location = new System.Drawing.Point(147, 113);
            this.textoSaldo.Name = "textoSaldo";
            this.textoSaldo.Size = new System.Drawing.Size(100, 20);
            this.textoSaldo.TabIndex = 2;
            // 
            // textoValor
            // 
            this.textoValor.Location = new System.Drawing.Point(149, 31);
            this.textoValor.Name = "textoValor";
            this.textoValor.Size = new System.Drawing.Size(100, 20);
            this.textoValor.TabIndex = 3;
            // 
            // botaoDeposito
            // 
            this.botaoDeposito.Location = new System.Drawing.Point(6, 73);
            this.botaoDeposito.Name = "botaoDeposito";
            this.botaoDeposito.Size = new System.Drawing.Size(75, 27);
            this.botaoDeposito.TabIndex = 4;
            this.botaoDeposito.Text = "Deposita";
            this.botaoDeposito.UseVisualStyleBackColor = true;
            this.botaoDeposito.Click += new System.EventHandler(this.button1_Click);
            // 
            // botaoSaque
            // 
            this.botaoSaque.Location = new System.Drawing.Point(103, 73);
            this.botaoSaque.Name = "botaoSaque";
            this.botaoSaque.Size = new System.Drawing.Size(75, 27);
            this.botaoSaque.TabIndex = 5;
            this.botaoSaque.Text = "Saca";
            this.botaoSaque.UseVisualStyleBackColor = true;
            this.botaoSaque.Click += new System.EventHandler(this.botaoSaque_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Titular";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Numero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Saldo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Valor de operação";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Escolha a Conta";
            // 
            // BotaoDeBusca
            // 
            this.BotaoDeBusca.Location = new System.Drawing.Point(92, 64);
            this.BotaoDeBusca.Name = "BotaoDeBusca";
            this.BotaoDeBusca.Size = new System.Drawing.Size(75, 27);
            this.BotaoDeBusca.TabIndex = 12;
            this.BotaoDeBusca.Text = "Buscar";
            this.BotaoDeBusca.UseVisualStyleBackColor = true;
            this.BotaoDeBusca.Click += new System.EventHandler(this.BotaoDeBusca_Click);
            // 
            // comboContas
            // 
            this.comboContas.FormattingEnabled = true;
            this.comboContas.Location = new System.Drawing.Point(141, 37);
            this.comboContas.Name = "comboContas";
            this.comboContas.Size = new System.Drawing.Size(121, 21);
            this.comboContas.TabIndex = 13;
            // 
            // bataoCadastro
            // 
            this.bataoCadastro.Location = new System.Drawing.Point(37, 479);
            this.bataoCadastro.Name = "bataoCadastro";
            this.bataoCadastro.Size = new System.Drawing.Size(75, 27);
            this.bataoCadastro.TabIndex = 14;
            this.bataoCadastro.Text = "Nova conta";
            this.bataoCadastro.UseVisualStyleBackColor = true;
            this.bataoCadastro.Click += new System.EventHandler(this.bataoCadastro_Click);
            // 
            // botaoImpostos
            // 
            this.botaoImpostos.Location = new System.Drawing.Point(194, 73);
            this.botaoImpostos.Name = "botaoImpostos";
            this.botaoImpostos.Size = new System.Drawing.Size(75, 27);
            this.botaoImpostos.TabIndex = 15;
            this.botaoImpostos.Text = "Impostos";
            this.botaoImpostos.UseVisualStyleBackColor = true;
            this.botaoImpostos.Click += new System.EventHandler(this.botaoImpostos_Click);
            // 
            // botRel
            // 
            this.botRel.Location = new System.Drawing.Point(151, 479);
            this.botRel.Name = "botRel";
            this.botRel.Size = new System.Drawing.Size(75, 27);
            this.botRel.TabIndex = 16;
            this.botRel.Text = "Relatorio";
            this.botRel.UseVisualStyleBackColor = true;
            this.botRel.Click += new System.EventHandler(this.botRel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboContas);
            this.groupBox1.Controls.Add(this.BotaoDeBusca);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(37, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 114);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Contas";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tiConta);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textoTitular);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textoNumero);
            this.groupBox2.Controls.Add(this.textoSaldo);
            this.groupBox2.Location = new System.Drawing.Point(37, 132);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(289, 192);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tipo de Conta";
            // 
            // tiConta
            // 
            this.tiConta.Location = new System.Drawing.Point(147, 154);
            this.tiConta.Name = "tiConta";
            this.tiConta.Size = new System.Drawing.Size(100, 20);
            this.tiConta.TabIndex = 9;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.textoValor);
            this.groupBox3.Controls.Add(this.botaoDeposito);
            this.groupBox3.Controls.Add(this.botaoSaque);
            this.groupBox3.Controls.Add(this.botaoImpostos);
            this.groupBox3.Location = new System.Drawing.Point(37, 347);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(289, 112);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Operação";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 520);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.botRel);
            this.Controls.Add(this.bataoCadastro);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button botRel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tiConta;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

