using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace aula_1
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        decimal vNumAnt;
        string vOperacao;
        bool vLimpar = false;

        private void btn_igual_Click(object sender, EventArgs e)
        {
            decimal vNumAtual = decimal.Parse(lbl_Visor.Text);
            switch (vOperacao)
            {
                case "+":
                    {
                        lbl_Visor.Text = (vNumAnt + vNumAtual).ToString();
                        break;
                    }
                case "-":
                    {
                        lbl_Visor.Text = (vNumAnt - vNumAtual).ToString();
                        break;
                    }
                case "x":
                    {
                        lbl_Visor.Text = (vNumAnt * vNumAtual).ToString();
                        break;
                    }
                    case "/":
                    {
                        try
                        {
                            lbl_Visor.Text = (vNumAnt / vNumAtual).ToString();
                        }
                        catch (DivideByZeroException)
                        {
                            lbl_Visor.Text = ("Nao é possivel dividir por zero");
                        }
                        break;
                    }
            }

        }
        private void MetNumero(object sender, EventArgs e)
        {
            string vNumero = ((Button)sender).Text;

            if (vLimpar)
            {
                lbl_Visor.Text = "";
                vLimpar = false;
            }
            if (lbl_Visor.Text == "0")
                lbl_Visor.Text = "";
            if((vNumero == "," && !lbl_Visor.Text.Contains(",")) || vNumero!=",")
            {
                lbl_Visor.Text += vNumero;
            }
            lbl_Visor.Focus();
        }

        private void btnOperacao(object sender, EventArgs e)
        {
            vOperacao = ((Button)sender).Text;
            vNumAnt = decimal.Parse(lbl_Visor.Text);
            vLimpar = true;
        }

        private void btn_inverteSinal_Click(object sender, EventArgs e)
        {
            lbl_Visor.Text = (decimal.Parse(lbl_Visor.Text) * -1).ToString();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            lbl_Visor.Text = lbl_Visor.Text.Substring(0, lbl_Visor.Text.Length - 1);
            if (lbl_Visor.Text == "")
            {
                lbl_Visor.Text = "0";
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Button bot = new Button();

            label1.Text = e.KeyCode.ToString();

            if((e.KeyCode>=Keys.D0 && e.KeyCode <= Keys.D9))
            {
                bot.Text = e.KeyCode.ToString().Substring(1, 1);
                MetNumero(bot, e);
                return;
            }
            else if((e.KeyCode == Keys.Oemcomma))
            {
                bot.Text = ",";
                MetNumero(bot, e);
                return;
            }

            
            switch (e.KeyCode.ToString())
            {
                case "soma":
                    {
                        bot.Text = "+";
                        MetNumero(bot, e);
                        return;

                    }
                case "subtrair":
                    {
                        bot.Text = "-";
                        MetNumero(bot, e);
                        return;
                    }
                case "multiplicar":
                    {
                        bot.Text = "x";
                        MetNumero(bot, e);
                        return;
                    }
                case "dividir":
                    {
                        
                        bot.Text = "/";
                        MetNumero(bot, e);
                        return;
                    }
            }
            if(e.KeyCode == Keys.Enter)
            {
                btn_igual_Click(bot, e);
            }
        }
    }



}
