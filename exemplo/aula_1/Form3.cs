using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace aula_1
{
    public partial class RdbButton : Form
    {
        public RdbButton()
        {
            InitializeComponent();
        }

        private void rdbSoma_CheckedChanged(object sender, EventArgs e)
        {
            lblsinal.Text = "+";
        }

        private void bdbSubtrair_CheckedChanged(object sender, EventArgs e)
        {
            lblsinal.Text = "-";
        }

        private void rdbMultiplicar_CheckedChanged(object sender, EventArgs e)
        {
            lblsinal.Text = "x";
        }

        private void rdbDividir_CheckedChanged(object sender, EventArgs e)
        {
            lblsinal.Text = "/";
        }

        private void rdbPotencia_CheckedChanged(object sender, EventArgs e)
        {
            lblsinal.Text = "^";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {

            
            double a, b, r;
            a = double.Parse(Txt1.Text);
            b = double.Parse(Txt2.Text);
                if(lblsinal.Text == "+")
                {
                    r = a + b;
                    lblResult.Text = r.ToString();
                }
                if(lblsinal.Text == "-")
                {
                    r = a - b;
                    lblResult.Text = r.ToString();
                 }
                if(lblsinal.Text == "x")
                {
                    r = a * b;
                    lblResult.Text = r.ToString();
                }
                if(lblsinal.Text == "/")
                {
                        r = a / b;
                        lblResult.Text = r.ToString();
                }
                if (b == 0)
                {
                    lblResult.Text = "Não é possivel dividir por zero";
                }

                if(lblsinal.Text == "^")
                {
                    r = Math.Pow(a, b);
                    lblResult.Text = r.ToString();
                }

               

                
        }

            catch (FormatException)
            {
                MessageBox.Show("Favor digitar apenas números");
            }



    
}

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Txt1.Clear();
            Txt2.Clear();
            lblsinal.Text = "?";
            lblResult.Text = "";
            Txt1.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}