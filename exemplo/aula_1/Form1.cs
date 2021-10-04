using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula_1
{
    public partial class frmCalculos : Form
    {
        public frmCalculos()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, r;
            lblSinal.Text = "+";
            try
            {
                a = double.Parse(txtN1.Text);
                b = double.Parse(txtN2.Text);

                r = a + b;
                lblResultado.Text = r.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Favor digitar apenas ´números");
            }

        }
        private void bntLimpar_Click(object sender, EventArgs e)
        {
            txtN1.Clear();
            txtN2.Clear();
            lblSinal.Text = "?";
            lblResultado.Text = "";
            txtN1.Focus();
        }

        private void bntFechar_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void bntSub_Click(object sender, EventArgs e)
        {
            double a, b, r;
            lblSinal.Text = "-";
            try
            {
                a = double.Parse(txtN1.Text);
                b = double.Parse(txtN2.Text);

                r = a - b;
                lblResultado.Text = r.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Favor digitar apenas números");
            }
        }

        private void bntMultiplicar_Click(object sender, EventArgs e)
        {
            double a, b, r;
            lblSinal.Text = "*";
            try
            {
                a = double.Parse(txtN1.Text);
                b = double.Parse(txtN2.Text);

                r = a * b;
                lblResultado.Text = r.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Favor digitar apenas números");
            }

        }

        private void bntDiv_Click_1(object sender, EventArgs e)
        {
            try
            {
                double a, b, r;
                lblSinal.Text = " / ";
                a = double.Parse(txtN1.Text);
                b = double.Parse(txtN2.Text);
                r = a / b;
                   
                 lblResultado.Text = r.ToString();
                    
                if(b == 0)
                {
                    lblResultado.Text = "Não é possivel dividir por zero";
                }
                
                
            }
            catch (FormatException)
            {
                MessageBox.Show("Digitar apenas números");
            }
            }
            


        private void bntPot_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b, r;
                lblSinal.Text = "^";
                a = double.Parse(txtN1.Text);
                b = double.Parse(txtN2.Text);

                r = Math.Pow(a, b);
                lblResultado.Text = r.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Favor digitar apenas números");
            }
        }

        private void bntParImpar_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b;
                lblSinal.Text = "par ou impar";
                a = double.Parse(txtN1.Text);
                b = double.Parse(txtN2.Text);
                if (a % 2 == 0 && b % 2 == 1)
                {
                    lblResultado.Text = ("o primeiro número é par e o segundo número é ímpar");
                }
                else if (a % 2 == 1 && b % 2 == 0)
                {
                    lblResultado.Text = ("o primeiro número é impar e o segundo número é par");
                }
                else if (a % 2 == 1 && b % 2 == 1)
                {
                    lblResultado.Text = ("os dois números são impares");
                }
                else
                {
                    lblResultado.Text = ("os dois números são pares");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Favor digitar apenas números");
            }

        }


        private void bntCompara_Click_1(object sender, EventArgs e)
        {
            try
            {

                double a, b;
                lblSinal.Text = "< ou >";
                a = double.Parse(txtN1.Text);
                b = double.Parse(txtN2.Text);
                if (a > b)
                {
                    lblResultado.Text = ("o primeiro número é maior");
                }
                else if (a < b)
                {
                    lblResultado.Text = ("o segundo número é maior");
                }
                else
                {
                    lblResultado.Text = ("os número são iguais");
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Favor digitar apenas números");
            }

        }
    }
}
