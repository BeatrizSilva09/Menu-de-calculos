
using System;

namespace aula_1
{
    partial class frmCalculos
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
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.lblSinal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnSomar = new System.Windows.Forms.Button();
            this.bntLimpar = new System.Windows.Forms.Button();
            this.bntFechar = new System.Windows.Forms.Button();
            this.bntSubtrair = new System.Windows.Forms.Button();
            this.bntMultiplicar = new System.Windows.Forms.Button();
            this.bntDiv = new System.Windows.Forms.Button();
            this.bntPot = new System.Windows.Forms.Button();
            this.bntParImpar = new System.Windows.Forms.Button();
            this.bntCompara = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(317, 38);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(100, 23);
            this.txtN1.TabIndex = 0;
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(317, 113);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(100, 23);
            this.txtN2.TabIndex = 1;
            // 
            // lblSinal
            // 
            this.lblSinal.AutoSize = true;
            this.lblSinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSinal.Location = new System.Drawing.Point(200, 87);
            this.lblSinal.Name = "lblSinal";
            this.lblSinal.Size = new System.Drawing.Size(14, 17);
            this.lblSinal.TabIndex = 2;
            this.lblSinal.Text = "?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "-------------------------";
            // 
            // lblResultado
            // 
            this.lblResultado.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblResultado.Location = new System.Drawing.Point(176, 207);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(377, 23);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblResultado.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnSomar
            // 
            this.btnSomar.Location = new System.Drawing.Point(602, 38);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(75, 23);
            this.btnSomar.TabIndex = 5;
            this.btnSomar.Text = "somar";
            this.btnSomar.UseVisualStyleBackColor = true;
            this.btnSomar.Click += new System.EventHandler(this.button1_Click);
            // 
            // bntLimpar
            // 
            this.bntLimpar.Location = new System.Drawing.Point(568, 345);
            this.bntLimpar.Name = "bntLimpar";
            this.bntLimpar.Size = new System.Drawing.Size(75, 23);
            this.bntLimpar.TabIndex = 6;
            this.bntLimpar.Text = "limpar";
            this.bntLimpar.UseVisualStyleBackColor = true;
            this.bntLimpar.Click += new System.EventHandler(this.bntLimpar_Click);
            // 
            // bntFechar
            // 
            this.bntFechar.Location = new System.Drawing.Point(627, 396);
            this.bntFechar.Name = "bntFechar";
            this.bntFechar.Size = new System.Drawing.Size(75, 23);
            this.bntFechar.TabIndex = 7;
            this.bntFechar.Text = "fechar";
            this.bntFechar.UseVisualStyleBackColor = true;
            this.bntFechar.Click += new System.EventHandler(this.bntFechar_Click);
            // 
            // bntSubtrair
            // 
            this.bntSubtrair.Location = new System.Drawing.Point(602, 87);
            this.bntSubtrair.Name = "bntSubtrair";
            this.bntSubtrair.Size = new System.Drawing.Size(75, 23);
            this.bntSubtrair.TabIndex = 8;
            this.bntSubtrair.Text = "subtrair";
            this.bntSubtrair.UseVisualStyleBackColor = true;
            this.bntSubtrair.Click += new System.EventHandler(this.bntSub_Click);
            // 
            // bntMultiplicar
            // 
            this.bntMultiplicar.Location = new System.Drawing.Point(602, 140);
            this.bntMultiplicar.Name = "bntMultiplicar";
            this.bntMultiplicar.Size = new System.Drawing.Size(75, 23);
            this.bntMultiplicar.TabIndex = 9;
            this.bntMultiplicar.Text = "multiplicar";
            this.bntMultiplicar.UseVisualStyleBackColor = true;
            this.bntMultiplicar.Click += new System.EventHandler(this.bntMultiplicar_Click);
            // 
            // bntDiv
            // 
            this.bntDiv.Location = new System.Drawing.Point(602, 189);
            this.bntDiv.Name = "bntDiv";
            this.bntDiv.Size = new System.Drawing.Size(75, 23);
            this.bntDiv.TabIndex = 10;
            this.bntDiv.Text = "dividir";
            this.bntDiv.UseVisualStyleBackColor = true;
            this.bntDiv.Click += new System.EventHandler(this.bntDiv_Click_1);
            // 
            // bntPot
            // 
            this.bntPot.Location = new System.Drawing.Point(602, 232);
            this.bntPot.Name = "bntPot";
            this.bntPot.Size = new System.Drawing.Size(75, 23);
            this.bntPot.TabIndex = 11;
            this.bntPot.Text = "potenciar";
            this.bntPot.UseVisualStyleBackColor = true;
            this.bntPot.Click += new System.EventHandler(this.bntPot_Click);
            // 
            // bntParImpar
            // 
            this.bntParImpar.Location = new System.Drawing.Point(293, 274);
            this.bntParImpar.Name = "bntParImpar";
            this.bntParImpar.Size = new System.Drawing.Size(75, 23);
            this.bntParImpar.TabIndex = 13;
            this.bntParImpar.Text = "ParImpar";
            this.bntParImpar.UseVisualStyleBackColor = true;
            this.bntParImpar.Click += new System.EventHandler(this.bntParImpar_Click);
            // 
            // bntCompara
            // 
            this.bntCompara.Location = new System.Drawing.Point(200, 274);
            this.bntCompara.Name = "bntCompara";
            this.bntCompara.Size = new System.Drawing.Size(75, 23);
            this.bntCompara.TabIndex = 14;
            this.bntCompara.Text = "Compara";
            this.bntCompara.UseVisualStyleBackColor = true;
            this.bntCompara.Click += new System.EventHandler(this.bntCompara_Click_1);
            // 
            // frmCalculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bntCompara);
            this.Controls.Add(this.bntParImpar);
            this.Controls.Add(this.bntPot);
            this.Controls.Add(this.bntDiv);
            this.Controls.Add(this.bntMultiplicar);
            this.Controls.Add(this.bntSubtrair);
            this.Controls.Add(this.bntFechar);
            this.Controls.Add(this.bntLimpar);
            this.Controls.Add(this.btnSomar);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSinal);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.txtN1);
            this.Name = "frmCalculos";
            this.Text = "calculos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void bntCompara_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.Label lblSinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.Button bntLimpar;
        private System.Windows.Forms.Button bntFechar;
        private System.Windows.Forms.Button bntSubtrair;
        private System.Windows.Forms.Button bntMultiplicar;
        private System.Windows.Forms.Button bntDiv;
        private System.Windows.Forms.Button bntPot;
        private System.Windows.Forms.Button bntParImpar;
        private System.Windows.Forms.Button bntCompara;
    }
}

