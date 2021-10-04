using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using aula_1.minhas_classes;

namespace aula_1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btn_Somar_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(textBox1.Text);
                double b = double.Parse(textBox2.Text);

                Calc ObjCalc = new Calc();
                ObjCalc.N1 = a;
                ObjCalc.N2 = b;
                ObjCalc.Somar();
                lblResultado.Text = ObjCalc.Resultado;
            }
            catch (FormatException)
            {
                MessageBox.Show("Digitar apenas números");
            }
        }

        private void btn_subtrair_Click(object sender, EventArgs e)
        {
            try
            {
                Calc ObjCalc = new Calc();
                ObjCalc.N1 = double.Parse(textBox1.Text);
                ObjCalc.N2 = double.Parse(textBox2.Text);
                lblResultado.Text = ObjCalc.Subtrair();
            }
            catch (FormatException)
            {
                MessageBox.Show("Digitar apenas números");
            }
        }

        private void btn_multiplicar_Click(object sender, EventArgs e)
        {
            try
            {
                Calc ObjCalc = new Calc();
                lblResultado.Text =
                    ObjCalc.Multiplicar(double.Parse(textBox1.Text), double.Parse(textBox2.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("Digite apenas números");

            }
        }

        private void btn_dividir_Click(object sender, EventArgs e)
        {
            try
            {
                    double a = double.Parse(textBox1.Text);
                    double b = double.Parse(textBox2.Text);

                    Calc ObjCalc = new Calc();
               
                    ObjCalc.N1 = a;
                    ObjCalc.N2 = b;
                    ObjCalc.Dividir();
               
                    lblResultado.Text = ObjCalc.Resultado;
                
               
            }
            catch (FormatException)
            {
                MessageBox.Show("Digitar apenas números");
            }
        }

        public void btn_potencia_Click(object sender, EventArgs e)
        {
            try
            {
                CalcCientifica ObjCalc = new CalcCientifica();
                ObjCalc.N1 = double.Parse(textBox1.Text);
                ObjCalc.N2 = double.Parse(textBox2.Text);
                lblResultado.Text = ObjCalc.Potenciação();
            }
            catch (FormatException)
            {
                MessageBox.Show("Digitar apenas números");
            }
        }

        private void bntCompara_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(textBox1.Text);
                double b = double.Parse(textBox2.Text);

                CalcCientifica ObjCalc = new CalcCientifica();

                ObjCalc.N1 = a;
                ObjCalc.N2 = b;
                ObjCalc.ComparaNumero();

                lblResultado.Text = ObjCalc.Resultado;
            }
            catch (FormatException)
            {
                MessageBox.Show("Digitar apenas números");
            }
        }

        private void btnImparPar_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(textBox1.Text);
                double b = double.Parse(textBox2.Text);

                CalcCientifica ObjCalc = new CalcCientifica();

                ObjCalc.N1 = a;
                ObjCalc.N2 = b;
                ObjCalc.ImparPar();

                lblResultado.Text = ObjCalc.Resultado;
            }
            catch (FormatException)
            {
                MessageBox.Show("Digitar apenas números");
            }
        }

        private void btnAreaT_Click(object sender, EventArgs e)
        {
            try
            {
                CalcCientifica ObjCalc = new CalcCientifica();
                ObjCalc.N1 = double.Parse(textBox1.Text);
                ObjCalc.N2 = double.Parse(textBox2.Text);
                lblResultado.Text = ObjCalc.AreaTriangulo();
            }
            catch (FormatException)
            {
                MessageBox.Show("Digitar apenas números");
            }
        }
    }
    }
