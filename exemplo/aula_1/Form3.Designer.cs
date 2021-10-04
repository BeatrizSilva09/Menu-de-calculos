
namespace aula_1
{
    partial class RdbButton
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbPotencia = new System.Windows.Forms.RadioButton();
            this.rdbDividir = new System.Windows.Forms.RadioButton();
            this.rdbMultiplicar = new System.Windows.Forms.RadioButton();
            this.bdbSubtrair = new System.Windows.Forms.RadioButton();
            this.rdbSoma = new System.Windows.Forms.RadioButton();
            this.Txt1 = new System.Windows.Forms.TextBox();
            this.Txt2 = new System.Windows.Forms.TextBox();
            this.lblsinal = new System.Windows.Forms.Label();
            this.lblIgual = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbPotencia);
            this.groupBox1.Controls.Add(this.rdbDividir);
            this.groupBox1.Controls.Add(this.rdbMultiplicar);
            this.groupBox1.Controls.Add(this.bdbSubtrair);
            this.groupBox1.Controls.Add(this.rdbSoma);
            this.groupBox1.Location = new System.Drawing.Point(34, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 234);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operações";
            // 
            // rdbPotencia
            // 
            this.rdbPotencia.AutoSize = true;
            this.rdbPotencia.Location = new System.Drawing.Point(34, 197);
            this.rdbPotencia.Name = "rdbPotencia";
            this.rdbPotencia.Size = new System.Drawing.Size(90, 19);
            this.rdbPotencia.TabIndex = 4;
            this.rdbPotencia.TabStop = true;
            this.rdbPotencia.Text = "Potenciação";
            this.rdbPotencia.UseVisualStyleBackColor = true;
            this.rdbPotencia.CheckedChanged += new System.EventHandler(this.rdbPotencia_CheckedChanged);
            // 
            // rdbDividir
            // 
            this.rdbDividir.AutoSize = true;
            this.rdbDividir.Location = new System.Drawing.Point(34, 158);
            this.rdbDividir.Name = "rdbDividir";
            this.rdbDividir.Size = new System.Drawing.Size(63, 19);
            this.rdbDividir.TabIndex = 3;
            this.rdbDividir.TabStop = true;
            this.rdbDividir.Text = "Divisão";
            this.rdbDividir.UseVisualStyleBackColor = true;
            this.rdbDividir.CheckedChanged += new System.EventHandler(this.rdbDividir_CheckedChanged);
            // 
            // rdbMultiplicar
            // 
            this.rdbMultiplicar.AutoSize = true;
            this.rdbMultiplicar.Location = new System.Drawing.Point(34, 121);
            this.rdbMultiplicar.Name = "rdbMultiplicar";
            this.rdbMultiplicar.Size = new System.Drawing.Size(97, 19);
            this.rdbMultiplicar.TabIndex = 2;
            this.rdbMultiplicar.TabStop = true;
            this.rdbMultiplicar.Text = "Multiplicação";
            this.rdbMultiplicar.UseVisualStyleBackColor = true;
            this.rdbMultiplicar.CheckedChanged += new System.EventHandler(this.rdbMultiplicar_CheckedChanged);
            // 
            // bdbSubtrair
            // 
            this.bdbSubtrair.AutoSize = true;
            this.bdbSubtrair.Location = new System.Drawing.Point(34, 76);
            this.bdbSubtrair.Name = "bdbSubtrair";
            this.bdbSubtrair.Size = new System.Drawing.Size(78, 19);
            this.bdbSubtrair.TabIndex = 1;
            this.bdbSubtrair.TabStop = true;
            this.bdbSubtrair.Text = "Subtração";
            this.bdbSubtrair.UseVisualStyleBackColor = true;
            this.bdbSubtrair.CheckedChanged += new System.EventHandler(this.bdbSubtrair_CheckedChanged);
            // 
            // rdbSoma
            // 
            this.rdbSoma.AutoSize = true;
            this.rdbSoma.Location = new System.Drawing.Point(34, 34);
            this.rdbSoma.Name = "rdbSoma";
            this.rdbSoma.Size = new System.Drawing.Size(59, 19);
            this.rdbSoma.TabIndex = 0;
            this.rdbSoma.TabStop = true;
            this.rdbSoma.Text = "Somar";
            this.rdbSoma.UseVisualStyleBackColor = true;
            this.rdbSoma.CheckedChanged += new System.EventHandler(this.rdbSoma_CheckedChanged);
            // 
            // Txt1
            // 
            this.Txt1.Location = new System.Drawing.Point(260, 131);
            this.Txt1.Name = "Txt1";
            this.Txt1.Size = new System.Drawing.Size(100, 23);
            this.Txt1.TabIndex = 1;
            // 
            // Txt2
            // 
            this.Txt2.Location = new System.Drawing.Point(431, 131);
            this.Txt2.Name = "Txt2";
            this.Txt2.Size = new System.Drawing.Size(107, 23);
            this.Txt2.TabIndex = 2;
            // 
            // lblsinal
            // 
            this.lblsinal.AutoSize = true;
            this.lblsinal.Location = new System.Drawing.Point(392, 134);
            this.lblsinal.Name = "lblsinal";
            this.lblsinal.Size = new System.Drawing.Size(12, 15);
            this.lblsinal.TabIndex = 3;
            this.lblsinal.Text = "?";
            // 
            // lblIgual
            // 
            this.lblIgual.AutoSize = true;
            this.lblIgual.Location = new System.Drawing.Point(570, 134);
            this.lblIgual.Name = "lblIgual";
            this.lblIgual.Size = new System.Drawing.Size(15, 15);
            this.lblIgual.TabIndex = 4;
            this.lblIgual.Text = "=";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(607, 134);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 15);
            this.lblResult.TabIndex = 5;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(339, 228);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(463, 228);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(579, 226);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "Fechar";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // RdbButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblIgual);
            this.Controls.Add(this.lblsinal);
            this.Controls.Add(this.Txt2);
            this.Controls.Add(this.Txt1);
            this.Controls.Add(this.groupBox1);
            this.Name = "RdbButton";
            this.Text = "RadioButtons";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbPotencia;
        private System.Windows.Forms.RadioButton rdbDividir;
        private System.Windows.Forms.RadioButton rdbMultiplicar;
        private System.Windows.Forms.RadioButton bdbSubtrair;
        private System.Windows.Forms.RadioButton rdbSoma;
        private System.Windows.Forms.TextBox Txt1;
        private System.Windows.Forms.TextBox Txt2;
        private System.Windows.Forms.Label lblsinal;
        private System.Windows.Forms.Label lblIgual;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
    }
}