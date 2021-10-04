
using System;

namespace aula_1
{
    partial class Calculadora
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Visor = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_inverteSinal = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button17 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.btn_igual = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Visor
            // 
            this.lbl_Visor.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_Visor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Visor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Visor.Location = new System.Drawing.Point(21, 9);
            this.lbl_Visor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Visor.Name = "lbl_Visor";
            this.lbl_Visor.Size = new System.Drawing.Size(282, 34);
            this.lbl_Visor.TabIndex = 0;
            this.lbl_Visor.Text = "0";
            this.lbl_Visor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button13);
            this.panel1.Controls.Add(this.button12);
            this.panel1.Controls.Add(this.button11);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.btn_inverteSinal);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(21, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 277);
            this.panel1.TabIndex = 1;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(16, 31);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(54, 49);
            this.button13.TabIndex = 12;
            this.button13.Text = "9";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.MetNumero);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(76, 31);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(54, 49);
            this.button12.TabIndex = 11;
            this.button12.Text = "8";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.MetNumero);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(136, 31);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(54, 49);
            this.button11.TabIndex = 10;
            this.button11.Text = "7";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.MetNumero);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(16, 96);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(54, 49);
            this.button10.TabIndex = 9;
            this.button10.Text = "6";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.MetNumero);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(76, 96);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(54, 49);
            this.button9.TabIndex = 8;
            this.button9.Text = "5";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.MetNumero);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(136, 96);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(54, 49);
            this.button8.TabIndex = 7;
            this.button8.Text = "4";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.MetNumero);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(16, 164);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(54, 49);
            this.button7.TabIndex = 6;
            this.button7.Text = "1";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.MetNumero);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(72, 164);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(54, 49);
            this.button6.TabIndex = 5;
            this.button6.Text = "2";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.MetNumero);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(136, 164);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(54, 49);
            this.button5.TabIndex = 4;
            this.button5.Text = "3";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.MetNumero);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(359, 330);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(54, 49);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btn_inverteSinal
            // 
            this.btn_inverteSinal.Location = new System.Drawing.Point(12, 223);
            this.btn_inverteSinal.Name = "btn_inverteSinal";
            this.btn_inverteSinal.Size = new System.Drawing.Size(54, 49);
            this.btn_inverteSinal.TabIndex = 2;
            this.btn_inverteSinal.Text = "+/-";
            this.btn_inverteSinal.UseVisualStyleBackColor = true;
            this.btn_inverteSinal.Click += new System.EventHandler(this.btn_inverteSinal_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(72, 223);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(54, 49);
            this.button2.TabIndex = 1;
            this.button2.Text = "0";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.MetNumero);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(132, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = ",";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.MetNumero);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(213, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(71, 275);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button17);
            this.panel3.Controls.Add(this.button16);
            this.panel3.Controls.Add(this.button15);
            this.panel3.Controls.Add(this.button14);
            this.panel3.Location = new System.Drawing.Point(234, 78);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(71, 225);
            this.panel3.TabIndex = 2;
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(9, 8);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(54, 49);
            this.button17.TabIndex = 4;
            this.button17.Text = "/";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.btnOperacao);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(8, 63);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(54, 49);
            this.button16.TabIndex = 3;
            this.button16.Text = "-";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.btnOperacao);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(8, 118);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(54, 49);
            this.button15.TabIndex = 2;
            this.button15.Text = "x";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.btnOperacao);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(8, 173);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(54, 49);
            this.button14.TabIndex = 1;
            this.button14.Text = "+";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.btnOperacao);
            // 
            // btn_igual
            // 
            this.btn_igual.Location = new System.Drawing.Point(242, 306);
            this.btn_igual.Name = "btn_igual";
            this.btn_igual.Size = new System.Drawing.Size(54, 49);
            this.btn_igual.TabIndex = 3;
            this.btn_igual.Text = "=";
            this.btn_igual.UseVisualStyleBackColor = true;
            this.btn_igual.Click += new System.EventHandler(this.btn_igual_Click);
            // 
            // btn_voltar
            // 
            this.btn_voltar.Location = new System.Drawing.Point(235, 49);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(68, 23);
            this.btn_voltar.TabIndex = 5;
            this.btn_voltar.Text = "<--";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 6;
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(309, 358);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_igual);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_Visor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Name = "Calculadora";
            this.Text = "Calculadora";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Visor;
        private EventHandler lbl_Visor_Click;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_inverteSinal;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button btn_igual;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Label label1;
    }
}