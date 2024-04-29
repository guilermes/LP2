namespace PSalario
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtBoxNome = new TextBox();
            lblNome = new Label();
            lblSalario = new Label();
            lblFilhos = new Label();
            numBxFilhos = new NumericUpDown();
            lblAliqINSS = new Label();
            txtBoxAliqINSS = new TextBox();
            txtBoxAliqIRPF = new TextBox();
            lblAliqIRPF = new Label();
            label6 = new Label();
            txtBoxSalarioLiquido = new TextBox();
            lblSalarioLiquido = new Label();
            btnVerifica = new Button();
            btnSair = new Button();
            txtBoxDescINSS = new TextBox();
            lblDescontoINSS = new Label();
            txtBoxDescIRPF = new TextBox();
            lblIRPF = new Label();
            mskTxtBoxSalario = new MaskedTextBox();
            txtBxSalarioFamilia = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numBxFilhos).BeginInit();
            SuspendLayout();
            // 
            // txtBoxNome
            // 
            txtBoxNome.Location = new Point(108, 41);
            txtBoxNome.Name = "txtBoxNome";
            txtBoxNome.Size = new Size(355, 23);
            txtBoxNome.TabIndex = 0;
            txtBoxNome.TextChanged += txtBoxNome_TextChanged;
            txtBoxNome.KeyPress += txtBoxNome_KeyPress;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(60, 47);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome:";
            // 
            // lblSalario
            // 
            lblSalario.AutoSize = true;
            lblSalario.Location = new Point(60, 91);
            lblSalario.Name = "lblSalario";
            lblSalario.Size = new Size(77, 15);
            lblSalario.TabIndex = 3;
            lblSalario.Text = "Salário Bruto:";
            // 
            // lblFilhos
            // 
            lblFilhos.AutoSize = true;
            lblFilhos.Location = new Point(60, 130);
            lblFilhos.Name = "lblFilhos";
            lblFilhos.Size = new Size(104, 15);
            lblFilhos.TabIndex = 4;
            lblFilhos.Text = "Número de Filhos:";
            // 
            // numBxFilhos
            // 
            numBxFilhos.Location = new Point(170, 128);
            numBxFilhos.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numBxFilhos.Name = "numBxFilhos";
            numBxFilhos.Size = new Size(74, 23);
            numBxFilhos.TabIndex = 5;
            // 
            // lblAliqINSS
            // 
            lblAliqINSS.AutoSize = true;
            lblAliqINSS.Location = new Point(55, 235);
            lblAliqINSS.Name = "lblAliqINSS";
            lblAliqINSS.Size = new Size(82, 15);
            lblAliqINSS.TabIndex = 6;
            lblAliqINSS.Text = "Alíquota INSS:";
            // 
            // txtBoxAliqINSS
            // 
            txtBoxAliqINSS.Enabled = false;
            txtBoxAliqINSS.Location = new Point(144, 227);
            txtBoxAliqINSS.Name = "txtBoxAliqINSS";
            txtBoxAliqINSS.Size = new Size(100, 23);
            txtBoxAliqINSS.TabIndex = 7;
            // 
            // txtBoxAliqIRPF
            // 
            txtBoxAliqIRPF.Enabled = false;
            txtBoxAliqIRPF.Location = new Point(363, 230);
            txtBoxAliqIRPF.Name = "txtBoxAliqIRPF";
            txtBoxAliqIRPF.Size = new Size(100, 23);
            txtBoxAliqIRPF.TabIndex = 9;
            // 
            // lblAliqIRPF
            // 
            lblAliqIRPF.AutoSize = true;
            lblAliqIRPF.Location = new Point(274, 238);
            lblAliqIRPF.Name = "lblAliqIRPF";
            lblAliqIRPF.Size = new Size(81, 15);
            lblAliqIRPF.TabIndex = 8;
            lblAliqIRPF.Text = "Alíquota IRPF:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(52, 348);
            label6.Name = "label6";
            label6.Size = new Size(86, 15);
            label6.TabIndex = 10;
            label6.Text = "Salário Família:";
            // 
            // txtBoxSalarioLiquido
            // 
            txtBoxSalarioLiquido.Enabled = false;
            txtBoxSalarioLiquido.Location = new Point(363, 340);
            txtBoxSalarioLiquido.Name = "txtBoxSalarioLiquido";
            txtBoxSalarioLiquido.Size = new Size(100, 23);
            txtBoxSalarioLiquido.TabIndex = 13;
            // 
            // lblSalarioLiquido
            // 
            lblSalarioLiquido.AutoSize = true;
            lblSalarioLiquido.Location = new Point(271, 348);
            lblSalarioLiquido.Name = "lblSalarioLiquido";
            lblSalarioLiquido.Size = new Size(88, 15);
            lblSalarioLiquido.TabIndex = 12;
            lblSalarioLiquido.Text = "Salário Líquido:";
            // 
            // btnVerifica
            // 
            btnVerifica.Location = new Point(184, 182);
            btnVerifica.Name = "btnVerifica";
            btnVerifica.Size = new Size(139, 23);
            btnVerifica.TabIndex = 14;
            btnVerifica.Text = "Verificar Desconto";
            btnVerifica.UseVisualStyleBackColor = true;
            btnVerifica.Click += btnVerifica_Click;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(236, 395);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(75, 23);
            btnSair.TabIndex = 15;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // txtBoxDescINSS
            // 
            txtBoxDescINSS.Enabled = false;
            txtBoxDescINSS.Location = new Point(144, 278);
            txtBoxDescINSS.Name = "txtBoxDescINSS";
            txtBoxDescINSS.Size = new Size(100, 23);
            txtBoxDescINSS.TabIndex = 17;
            // 
            // lblDescontoINSS
            // 
            lblDescontoINSS.AutoSize = true;
            lblDescontoINSS.Location = new Point(51, 284);
            lblDescontoINSS.Name = "lblDescontoINSS";
            lblDescontoINSS.Size = new Size(87, 15);
            lblDescontoINSS.TabIndex = 16;
            lblDescontoINSS.Text = "Desconto INSS:";
            // 
            // txtBoxDescIRPF
            // 
            txtBoxDescIRPF.Enabled = false;
            txtBoxDescIRPF.Location = new Point(363, 281);
            txtBoxDescIRPF.Name = "txtBoxDescIRPF";
            txtBoxDescIRPF.Size = new Size(100, 23);
            txtBoxDescIRPF.TabIndex = 19;
            // 
            // lblIRPF
            // 
            lblIRPF.AutoSize = true;
            lblIRPF.Location = new Point(271, 289);
            lblIRPF.Name = "lblIRPF";
            lblIRPF.Size = new Size(86, 15);
            lblIRPF.TabIndex = 18;
            lblIRPF.Text = "Desconto IRPF:";
            // 
            // mskTxtBoxSalario
            // 
            mskTxtBoxSalario.Location = new Point(143, 83);
            mskTxtBoxSalario.Mask = "$ 0000.00";
            mskTxtBoxSalario.Name = "mskTxtBoxSalario";
            mskTxtBoxSalario.Size = new Size(180, 23);
            mskTxtBoxSalario.TabIndex = 20;
            mskTxtBoxSalario.Validated += mskTxtBoxSalario_Validated;
            // 
            // txtBxSalarioFamilia
            // 
            txtBxSalarioFamilia.Location = new Point(143, 340);
            txtBxSalarioFamilia.Name = "txtBxSalarioFamilia";
            txtBxSalarioFamilia.Size = new Size(101, 23);
            txtBxSalarioFamilia.TabIndex = 21;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 450);
            Controls.Add(txtBxSalarioFamilia);
            Controls.Add(mskTxtBoxSalario);
            Controls.Add(txtBoxDescIRPF);
            Controls.Add(lblIRPF);
            Controls.Add(txtBoxDescINSS);
            Controls.Add(lblDescontoINSS);
            Controls.Add(btnSair);
            Controls.Add(btnVerifica);
            Controls.Add(txtBoxSalarioLiquido);
            Controls.Add(lblSalarioLiquido);
            Controls.Add(label6);
            Controls.Add(txtBoxAliqIRPF);
            Controls.Add(lblAliqIRPF);
            Controls.Add(txtBoxAliqINSS);
            Controls.Add(lblAliqINSS);
            Controls.Add(numBxFilhos);
            Controls.Add(lblFilhos);
            Controls.Add(lblSalario);
            Controls.Add(lblNome);
            Controls.Add(txtBoxNome);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numBxFilhos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxNome;
        private Label lblNome;
        private Label lblSalario;
        private Label lblFilhos;
        private NumericUpDown numBxFilhos;
        private Label lblAliqINSS;
        private TextBox txtBoxAliqINSS;
        private TextBox txtBoxAliqIRPF;
        private Label lblAliqIRPF;
        private Label label6;
        private TextBox txtBoxSalarioLiquido;
        private Label lblSalarioLiquido;
        private Button btnVerifica;
        private Button btnSair;
        private TextBox txtBoxDescINSS;
        private Label lblDescontoINSS;
        private TextBox txtBoxDescIRPF;
        private Label lblIRPF;
        private MaskedTextBox mskTxtBoxSalario;
        private TextBox txtBxSalarioFamilia;
    }
}
