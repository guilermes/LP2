namespace PSalario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtBoxNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || Char.IsPunctuation(e.KeyChar))
            {
                MessageBox.Show("Caracter inválido! Digite novamente.");
                SendKeys.Send("{BACKSPACE}");
            }
        }


        private void mskTxtBoxSalario_Validated(object sender, EventArgs e)
        {

        }

        private void btnVerifica_Click(object sender, EventArgs e)
        {
            //criação de variáveis
            double salarioBruto = Convert.ToDouble(mskTxtBoxSalario.Text);
            double numFilhos = Convert.ToDouble(numBxFilhos.Value);
            double descontoINSS = 0;
            double descontoIRPF = 0;
            double salarioFamilia = 0;
            double salarioLiquido = 0;

            //calculo de INSS
            if (salarioBruto <= 800.47)
            {
                txtBoxAliqINSS.Text = "7,65%";
                descontoINSS = 00765 * salarioBruto;
            }
            else if (salarioBruto < 1050)
            {
                txtBoxAliqINSS.Text = "8,65%";
                descontoINSS = 00865 * salarioBruto;
            }
            else if (salarioBruto < 1400.77)
            {
                txtBoxAliqINSS.Text = "9,00%";
                descontoINSS = 00900 * salarioBruto;
            }
            else if (salarioBruto < 2801.56)
            {
                txtBoxAliqINSS.Text = "11,00%";
                descontoINSS = 01100 * salarioBruto;
            }
            else
            {
                txtBoxAliqINSS.Text = "Teto";
                descontoINSS = 308.17;
            }

            //calculo IRPF
            if (salarioBruto < 1257.12)
            {
                txtBoxAliqIRPF.Text = "Isento";
            }
            else if (salarioBruto < 2512.08)
            {
                txtBoxAliqIRPF.Text = "15,00%";
                descontoIRPF = 01500 * salarioBruto;
            }
            else if (salarioBruto > 2512.08)
            {
                txtBoxAliqIRPF.Text = "27,5%";
                descontoIRPF = 02750 * salarioBruto;
            }

            //calculo salario familia
            if (salarioBruto <= 435.52)
            {
                salarioFamilia = 22.3 * numFilhos;
                txtBxSalarioFamilia.Text = ($"{salarioFamilia}");
            }
            else if (salarioBruto < 654.61)
            {
                salarioFamilia = 15.74 * numFilhos;
                txtBxSalarioFamilia.Text = ($"{salarioFamilia}");
            }
            else if (salarioFamilia > 654.61)
            {
                salarioFamilia = 0 * numFilhos;
                txtBxSalarioFamilia.Text = ($"{salarioFamilia}");
            }

            //calculo salario liquido
            salarioLiquido = salarioBruto - descontoIRPF - descontoINSS + salarioFamilia;
            txtBoxSalarioLiquido.Text = salarioLiquido.ToString("N2");
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
