
namespace CALCULADORA1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMenos = new System.Windows.Forms.Button();
            this.btnVezes = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnMais = new System.Windows.Forms.Button();
            this.btnSai = new System.Windows.Forms.Button();
            this.btnLmp = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.eblResult = new System.Windows.Forms.Label();
            this.eblNum2 = new System.Windows.Forms.Label();
            this.eblNum1 = new System.Windows.Forms.Label();
            this.eblCalc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMenos
            // 
            this.btnMenos.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnMenos.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenos.ForeColor = System.Drawing.Color.Black;
            this.btnMenos.Location = new System.Drawing.Point(121, 151);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(57, 39);
            this.btnMenos.TabIndex = 29;
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyleBackColor = false;
            this.btnMenos.Click += new System.EventHandler(this.btnMenos_Click);
            // 
            // btnVezes
            // 
            this.btnVezes.BackColor = System.Drawing.Color.Yellow;
            this.btnVezes.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVezes.ForeColor = System.Drawing.Color.Black;
            this.btnVezes.Location = new System.Drawing.Point(194, 151);
            this.btnVezes.Name = "btnVezes";
            this.btnVezes.Size = new System.Drawing.Size(57, 39);
            this.btnVezes.TabIndex = 28;
            this.btnVezes.Text = "x";
            this.btnVezes.UseVisualStyleBackColor = false;
            this.btnVezes.Click += new System.EventHandler(this.btnVezes_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.BackColor = System.Drawing.Color.Lime;
            this.btnDividir.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDividir.ForeColor = System.Drawing.Color.Black;
            this.btnDividir.Location = new System.Drawing.Point(268, 151);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(57, 39);
            this.btnDividir.TabIndex = 27;
            this.btnDividir.Text = "÷";
            this.btnDividir.UseVisualStyleBackColor = false;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // btnMais
            // 
            this.btnMais.BackColor = System.Drawing.Color.Red;
            this.btnMais.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMais.ForeColor = System.Drawing.Color.Black;
            this.btnMais.Location = new System.Drawing.Point(52, 151);
            this.btnMais.Name = "btnMais";
            this.btnMais.Size = new System.Drawing.Size(57, 39);
            this.btnMais.TabIndex = 26;
            this.btnMais.Text = "+";
            this.btnMais.UseVisualStyleBackColor = false;
            this.btnMais.Click += new System.EventHandler(this.btnMais_Click);
            // 
            // btnSai
            // 
            this.btnSai.BackColor = System.Drawing.Color.Black;
            this.btnSai.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSai.ForeColor = System.Drawing.Color.White;
            this.btnSai.Location = new System.Drawing.Point(207, 268);
            this.btnSai.Name = "btnSai";
            this.btnSai.Size = new System.Drawing.Size(87, 32);
            this.btnSai.TabIndex = 25;
            this.btnSai.Text = "Sair";
            this.btnSai.UseVisualStyleBackColor = false;
            this.btnSai.Click += new System.EventHandler(this.btnSai_Click);
            // 
            // btnLmp
            // 
            this.btnLmp.BackColor = System.Drawing.Color.Black;
            this.btnLmp.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLmp.ForeColor = System.Drawing.Color.White;
            this.btnLmp.Location = new System.Drawing.Point(97, 268);
            this.btnLmp.Name = "btnLmp";
            this.btnLmp.Size = new System.Drawing.Size(87, 32);
            this.btnLmp.TabIndex = 24;
            this.btnLmp.Text = "Limpar";
            this.btnLmp.UseVisualStyleBackColor = false;
            this.btnLmp.Click += new System.EventHandler(this.btnLmp_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.Color.White;
            this.txtResultado.Enabled = false;
            this.txtResultado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.ForeColor = System.Drawing.Color.Black;
            this.txtResultado.Location = new System.Drawing.Point(106, 218);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(247, 27);
            this.txtResultado.TabIndex = 23;
            // 
            // txtNum2
            // 
            this.txtNum2.BackColor = System.Drawing.Color.White;
            this.txtNum2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNum2.Location = new System.Drawing.Point(106, 104);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(247, 20);
            this.txtNum2.TabIndex = 22;
            // 
            // txtNum1
            // 
            this.txtNum1.BackColor = System.Drawing.Color.White;
            this.txtNum1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNum1.Location = new System.Drawing.Point(106, 52);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(247, 20);
            this.txtNum1.TabIndex = 21;
            this.txtNum1.TextChanged += new System.EventHandler(this.txtNum1_TextChanged);
            // 
            // eblResult
            // 
            this.eblResult.AutoSize = true;
            this.eblResult.BackColor = System.Drawing.Color.Black;
            this.eblResult.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eblResult.ForeColor = System.Drawing.Color.White;
            this.eblResult.Location = new System.Drawing.Point(1, 224);
            this.eblResult.Name = "eblResult";
            this.eblResult.Size = new System.Drawing.Size(106, 18);
            this.eblResult.TabIndex = 20;
            this.eblResult.Text = "Resultado";
            // 
            // eblNum2
            // 
            this.eblNum2.AutoSize = true;
            this.eblNum2.BackColor = System.Drawing.Color.Black;
            this.eblNum2.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eblNum2.ForeColor = System.Drawing.Color.White;
            this.eblNum2.Location = new System.Drawing.Point(15, 104);
            this.eblNum2.Name = "eblNum2";
            this.eblNum2.Size = new System.Drawing.Size(92, 18);
            this.eblNum2.TabIndex = 19;
            this.eblNum2.Text = "Número 2";
            // 
            // eblNum1
            // 
            this.eblNum1.AutoSize = true;
            this.eblNum1.BackColor = System.Drawing.Color.Black;
            this.eblNum1.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eblNum1.ForeColor = System.Drawing.Color.White;
            this.eblNum1.Location = new System.Drawing.Point(15, 52);
            this.eblNum1.Name = "eblNum1";
            this.eblNum1.Size = new System.Drawing.Size(92, 18);
            this.eblNum1.TabIndex = 18;
            this.eblNum1.Text = "Número 1";
            // 
            // eblCalc
            // 
            this.eblCalc.AutoSize = true;
            this.eblCalc.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eblCalc.ForeColor = System.Drawing.Color.White;
            this.eblCalc.Location = new System.Drawing.Point(82, 9);
            this.eblCalc.Name = "eblCalc";
            this.eblCalc.Size = new System.Drawing.Size(212, 30);
            this.eblCalc.TabIndex = 30;
            this.eblCalc.Text = "Calculadora";
            this.eblCalc.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(374, 312);
            this.Controls.Add(this.eblCalc);
            this.Controls.Add(this.btnMenos);
            this.Controls.Add(this.btnVezes);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnMais);
            this.Controls.Add(this.btnSai);
            this.Controls.Add(this.btnLmp);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.eblResult);
            this.Controls.Add(this.eblNum2);
            this.Controls.Add(this.eblNum1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.Button btnVezes;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnMais;
        private System.Windows.Forms.Button btnSai;
        private System.Windows.Forms.Button btnLmp;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.Label eblResult;
        private System.Windows.Forms.Label eblNum2;
        private System.Windows.Forms.Label eblNum1;
        private System.Windows.Forms.Label eblCalc;
    }
}

