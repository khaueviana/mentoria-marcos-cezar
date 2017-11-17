namespace Banco
{
    partial class FormRelatorios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listResultado = new System.Windows.Forms.ListBox();
            this.botaoFiltraSaldo = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listResultado
            // 
            this.listResultado.FormattingEnabled = true;
            this.listResultado.Location = new System.Drawing.Point(24, 30);
            this.listResultado.Name = "listResultado";
            this.listResultado.Size = new System.Drawing.Size(303, 173);
            this.listResultado.TabIndex = 0;
            // 
            // botaoFiltraSaldo
            // 
            this.botaoFiltraSaldo.Location = new System.Drawing.Point(36, 264);
            this.botaoFiltraSaldo.Name = "botaoFiltraSaldo";
            this.botaoFiltraSaldo.Size = new System.Drawing.Size(189, 23);
            this.botaoFiltraSaldo.TabIndex = 1;
            this.botaoFiltraSaldo.Text = "Saldo Maior do que 200";
            this.botaoFiltraSaldo.UseVisualStyleBackColor = true;
            this.botaoFiltraSaldo.Click += new System.EventHandler(this.botaoFiltraSaldo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listResultado);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 227);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busca de contas";
            // 
            // FormRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 319);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.botaoFiltraSaldo);
            this.Name = "FormRelatorios";
            this.Text = "FormRelatorios";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listResultado;
        private System.Windows.Forms.Button botaoFiltraSaldo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}