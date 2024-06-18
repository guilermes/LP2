using System;
using System.Windows.Forms;

namespace PReava
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {

            double[] matrizA = new double[14];
            double[] matrizB = new double[14];
            string auxiliar;

            for (int i = 1; i < 14; i++)
            {
                double j = i;
                matrizA[i] = j;


                if (matrizA[i] % 2 == 0)
                {
                    matrizB[i] = j * 4;
                }
                else
                {
                    matrizB[i] = j + 4;
                }

                auxiliar = ("Posição:" + i + " Matriz A = " + matrizA[(int)j] + " Matriz B =" + matrizB[(int)j]);
                listBoxMostrar.Items.Add(auxiliar);
            }
            
           
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            listBoxMostrar.Items.Clear();
        }
    }
}
