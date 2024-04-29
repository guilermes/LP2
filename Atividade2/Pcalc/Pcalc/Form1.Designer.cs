namespace Pcalc
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
            btnSoma = new Button();
            btnSub = new Button();
            btnMult = new Button();
            btnDiv = new Button();
            btnLimpa = new Button();
            btnSai = new Button();
            txtBoxNum1 = new TextBox();
            txtBoxNum2 = new TextBox();
            txtBoxRes = new TextBox();
            lblNum1 = new Label();
            lblNum2 = new Label();
            lblRes = new Label();
            SuspendLayout();
            // 
            // btnSoma
            // 
            btnSoma.Location = new Point(28, 181);
            btnSoma.Name = "btnSoma";
            btnSoma.Size = new Size(75, 23);
            btnSoma.TabIndex = 0;
            btnSoma.Text = "+";
            btnSoma.UseVisualStyleBackColor = true;
            btnSoma.Click += btnSoma_Click;
            // 
            // btnSub
            // 
            btnSub.Location = new Point(28, 226);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(75, 23);
            btnSub.TabIndex = 1;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += btnSub_Click;
            // 
            // btnMult
            // 
            btnMult.Location = new Point(118, 181);
            btnMult.Name = "btnMult";
            btnMult.Size = new Size(75, 23);
            btnMult.TabIndex = 2;
            btnMult.Text = "*";
            btnMult.UseVisualStyleBackColor = true;
            btnMult.Click += btnMult_Click;
            // 
            // btnDiv
            // 
            btnDiv.Location = new Point(118, 226);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(75, 23);
            btnDiv.TabIndex = 3;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += btnDiv_Click;
            // 
            // btnLimpa
            // 
            btnLimpa.Location = new Point(28, 276);
            btnLimpa.Name = "btnLimpa";
            btnLimpa.Size = new Size(75, 23);
            btnLimpa.TabIndex = 4;
            btnLimpa.Text = "Limpar";
            btnLimpa.UseVisualStyleBackColor = true;
            btnLimpa.Click += btnLimpa_Click;
            // 
            // btnSai
            // 
            btnSai.Location = new Point(118, 276);
            btnSai.Name = "btnSai";
            btnSai.Size = new Size(75, 23);
            btnSai.TabIndex = 5;
            btnSai.Text = "Sair";
            btnSai.UseVisualStyleBackColor = true;
            btnSai.Click += btnSai_Click;
            // 
            // txtBoxNum1
            // 
            txtBoxNum1.Location = new Point(118, 89);
            txtBoxNum1.Name = "txtBoxNum1";
            txtBoxNum1.Size = new Size(75, 23);
            txtBoxNum1.TabIndex = 6;
            txtBoxNum1.TextChanged += textBox1_TextChanged;
            txtBoxNum1.Leave += txtBoxNum1_Leave;
            txtBoxNum1.Validated += txtBoxNum1_Validated;
            // 
            // txtBoxNum2
            // 
            txtBoxNum2.Location = new Point(118, 131);
            txtBoxNum2.Name = "txtBoxNum2";
            txtBoxNum2.Size = new Size(75, 23);
            txtBoxNum2.TabIndex = 7;
            txtBoxNum2.Validated += txtBoxNum2_Validated;
            // 
            // txtBoxRes
            // 
            txtBoxRes.Font = new Font("Segoe UI", 14F);
            txtBoxRes.Location = new Point(118, 25);
            txtBoxRes.Name = "txtBoxRes";
            txtBoxRes.ReadOnly = true;
            txtBoxRes.Size = new Size(75, 32);
            txtBoxRes.TabIndex = 8;
            // 
            // lblNum1
            // 
            lblNum1.AutoSize = true;
            lblNum1.Font = new Font("Segoe UI", 12F);
            lblNum1.Location = new Point(28, 87);
            lblNum1.Name = "lblNum1";
            lblNum1.Size = new Size(84, 21);
            lblNum1.TabIndex = 9;
            lblNum1.Text = "Número 1:";
            lblNum1.Click += label1_Click;
            // 
            // lblNum2
            // 
            lblNum2.AutoSize = true;
            lblNum2.Font = new Font("Segoe UI", 12F);
            lblNum2.Location = new Point(28, 129);
            lblNum2.Name = "lblNum2";
            lblNum2.Size = new Size(84, 21);
            lblNum2.TabIndex = 10;
            lblNum2.Text = "Número 2:";
            // 
            // lblRes
            // 
            lblRes.AutoSize = true;
            lblRes.Font = new Font("Segoe UI", 12F);
            lblRes.Location = new Point(28, 23);
            lblRes.Name = "lblRes";
            lblRes.Size = new Size(82, 21);
            lblRes.TabIndex = 11;
            lblRes.Text = "Resultado:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(231, 330);
            Controls.Add(lblRes);
            Controls.Add(lblNum2);
            Controls.Add(lblNum1);
            Controls.Add(txtBoxRes);
            Controls.Add(txtBoxNum2);
            Controls.Add(txtBoxNum1);
            Controls.Add(btnSai);
            Controls.Add(btnLimpa);
            Controls.Add(btnDiv);
            Controls.Add(btnMult);
            Controls.Add(btnSub);
            Controls.Add(btnSoma);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSoma;
        private Button btnSub;
        private Button btnMult;
        private Button btnDiv;
        private Button btnLimpa;
        private Button btnSai;
        private TextBox txtBoxNum1;
        private TextBox txtBoxNum2;
        private TextBox txtBoxRes;
        private Label lblNum1;
        private Label lblNum2;
        private Label lblRes;
    }
}
