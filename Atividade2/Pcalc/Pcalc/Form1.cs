using System.Configuration;

namespace Pcalc
{
    public partial class Form1 : Form
    {
        double num1, num2, res; //variaveis globais
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxNum1_Leave(object sender, EventArgs e)
        {



        }

        private void txtBoxNum1_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(txtBoxNum1.Text, out num1))
            {
                MessageBox.Show("Valor inválido!");
                txtBoxNum2.Focus();
            }
        }

        private void txtBoxNum2_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(txtBoxNum2.Text, out num2))
            {
                MessageBox.Show("Valor inválido!");
                txtBoxNum2.Focus();
            }
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            res = num1 + num2;
            txtBoxRes.Text = res.ToString();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            res = num1 - num2;
            txtBoxRes.Text = res.ToString();
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            res = num1 * num2;
            txtBoxRes.Text = res.ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (num2 != 0)
            {
                res = num1 / num2;
                txtBoxRes.Text = res.ToString();
            }
            else
                MessageBox.Show("Não se pode dividir por zero!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtBoxNum2.Focus();
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            txtBoxNum1.Text = string.Empty;
            txtBoxNum2.Text = string.Empty;
            txtBoxRes.Text = string.Empty;

            //zerar varáveis e voltar para num1
            txtBoxNum1.Focus();
            res = 0;
            num1 = 0;
            num2 = 0;
        }

        private void btnSai_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
