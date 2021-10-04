using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace aula_1
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }
        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            string opc;
            opc = e.ClickedItem.Text;
            //MessageBox.Show(e.ClickedItem.Text);
            switch (opc)
            {
                case "Com botões":
                    {

                        break;
                    }
                case "Calculadora":
                    {
                        break;
                    }
                case "RadioButtons":
                    {
                        break;
                    }
                case "CalculadoraCientifica":
                    {
                        break;
                    }
            }
        }
        private void cálculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCalculos objCalBot = new frmCalculos();
            objCalBot.MdiParent = this;
            objCalBot.Show();
        }

        private void CalculadoraToolStripItem_Click(object sender, EventArgs e)
        {



            Calculadora objCalBot = new Calculadora();
            objCalBot.MdiParent = this;
            objCalBot.Show();

        }
        private void radioButtonsToolStripItem_Click(object sender, EventArgs e)
        {
            RdbButton objCalBot = new RdbButton();
            objCalBot.MdiParent = this;
            objCalBot.Show();
        }
        private void CalculadoraCientificaToolStripItem_Click(object sender, EventArgs e)
        {
            Form4 objCalBot = new Form4();
            objCalBot.MdiParent = this;
            objCalBot.Show();

        }
    }
}




