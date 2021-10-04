
namespace aula_1
{
    partial class Form4
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btn_Somar = new System.Windows.Forms.Button();
            this.btn_subtrair = new System.Windows.Forms.Button();
            this.btn_multiplicar = new System.Windows.Forms.Button();
            this.btn_potencia = new System.Windows.Forms.Button();
            this.btn_dividir = new System.Windows.Forms.Button();
            this.btnCompara = new System.Windows.Forms.Button();
            this.btnImparPar = new System.Windows.Forms.Button();
            this.btnAreaT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(311, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(311, 89);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 1;
            // 
            // lblResultado
            // 
            this.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResultado.Location = new System.Drawing.Point(260, 240);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(217, 45);
            this.lblResultado.TabIndex = 2;
            // 
            // btn_Somar
            // 
            this.btn_Somar.Location = new System.Drawing.Point(32, 145);
            this.btn_Somar.Name = "btn_Somar";
            this.btn_Somar.Size = new System.Drawing.Size(75, 23);
            this.btn_Somar.TabIndex = 3;
            this.btn_Somar.Text = "Somar";
            this.btn_Somar.UseVisualStyleBackColor = true;
            this.btn_Somar.Click += new System.EventHandler(this.btn_Somar_Click);
            // 
            // btn_subtrair
            // 
            this.btn_subtrair.Location = new System.Drawing.Point(123, 145);
            this.btn_subtrair.Name = "btn_subtrair";
            this.btn_subtrair.Size = new System.Drawing.Size(75, 23);
            this.btn_subtrair.TabIndex = 4;
            this.btn_subtrair.Text = "Subtrair";
            this.btn_subtrair.UseVisualStyleBackColor = true;
            this.btn_subtrair.Click += new System.EventHandler(this.btn_subtrair_Click);
            // 
            // btn_multiplicar
            // 
            this.btn_multiplicar.Location = new System.Drawing.Point(213, 145);
            this.btn_multiplicar.Name = "btn_multiplicar";
            this.btn_multiplicar.Size = new System.Drawing.Size(75, 23);
            this.btn_multiplicar.TabIndex = 5;
            this.btn_multiplicar.Text = "multiplicar";
            this.btn_multiplicar.UseVisualStyleBackColor = true;
            this.btn_multiplicar.Click += new System.EventHandler(this.btn_multiplicar_Click);
            // 
            // btn_potencia
            // 
            this.btn_potencia.Location = new System.Drawing.Point(402, 145);
            this.btn_potencia.Name = "btn_potencia";
            this.btn_potencia.Size = new System.Drawing.Size(75, 23);
            this.btn_potencia.TabIndex = 6;
            this.btn_potencia.Text = "potenciar";
            this.btn_potencia.UseVisualStyleBackColor = true;
            this.btn_potencia.Click += new System.EventHandler(this.btn_potencia_Click);
            // 
            // btn_dividir
            // 
            this.btn_dividir.Location = new System.Drawing.Point(311, 145);
            this.btn_dividir.Name = "btn_dividir";
            this.btn_dividir.Size = new System.Drawing.Size(75, 23);
            this.btn_dividir.TabIndex = 7;
            this.btn_dividir.Text = "dividir";
            this.btn_dividir.UseVisualStyleBackColor = true;
            this.btn_dividir.Click += new System.EventHandler(this.btn_dividir_Click);
            // 
            // btnCompara
            // 
            this.btnCompara.Location = new System.Drawing.Point(501, 145);
            this.btnCompara.Name = "btnCompara";
            this.btnCompara.Size = new System.Drawing.Size(75, 23);
            this.btnCompara.TabIndex = 9;
            this.btnCompara.Text = "< ou >";
            this.btnCompara.UseVisualStyleBackColor = true;
            this.btnCompara.Click += new System.EventHandler(this.bntCompara_Click);
            // 
            // btnImparPar
            // 
            this.btnImparPar.Location = new System.Drawing.Point(605, 145);
            this.btnImparPar.Name = "btnImparPar";
            this.btnImparPar.Size = new System.Drawing.Size(94, 23);
            this.btnImparPar.TabIndex = 10;
            this.btnImparPar.Text = "Par ou Ímpar";
            this.btnImparPar.UseVisualStyleBackColor = true;
            this.btnImparPar.Click += new System.EventHandler(this.btnImparPar_Click);
            // 
            // btnAreaT
            // 
            this.btnAreaT.Location = new System.Drawing.Point(32, 194);
            this.btnAreaT.Name = "btnAreaT";
            this.btnAreaT.Size = new System.Drawing.Size(94, 23);
            this.btnAreaT.TabIndex = 11;
            this.btnAreaT.Text = "Área Triângulo";
            this.btnAreaT.UseVisualStyleBackColor = true;
            this.btnAreaT.Click += new System.EventHandler(this.btnAreaT_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAreaT);
            this.Controls.Add(this.btnImparPar);
            this.Controls.Add(this.btnCompara);
            this.Controls.Add(this.btn_dividir);
            this.Controls.Add(this.btn_potencia);
            this.Controls.Add(this.btn_multiplicar);
            this.Controls.Add(this.btn_subtrair);
            this.Controls.Add(this.btn_Somar);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btn_Somar;
        private System.Windows.Forms.Button btn_subtrair;
        private System.Windows.Forms.Button btn_multiplicar;
        private System.Windows.Forms.Button btn_potencia;
        private System.Windows.Forms.Button btn_dividir;
        private System.Windows.Forms.Button btnCompara;
        private System.Windows.Forms.Button btnImparPar;
        private System.Windows.Forms.Button btnAreaT;
    }
}