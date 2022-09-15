namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.eblRaio = new System.Windows.Forms.Label();
            this.eblAltura = new System.Windows.Forms.Label();
            this.eblVolume = new System.Windows.Forms.Label();
            this.txtRaio = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtVolume = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // eblRaio
            // 
            this.eblRaio.AutoSize = true;
            this.eblRaio.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.eblRaio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eblRaio.ForeColor = System.Drawing.Color.Black;
            this.eblRaio.Location = new System.Drawing.Point(19, 22);
            this.eblRaio.Name = "eblRaio";
            this.eblRaio.Size = new System.Drawing.Size(36, 16);
            this.eblRaio.TabIndex = 0;
            this.eblRaio.Text = "Raio";
            this.eblRaio.Click += new System.EventHandler(this.label1_Click);
            // 
            // eblAltura
            // 
            this.eblAltura.AutoSize = true;
            this.eblAltura.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.eblAltura.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eblAltura.ForeColor = System.Drawing.Color.Black;
            this.eblAltura.Location = new System.Drawing.Point(19, 64);
            this.eblAltura.Name = "eblAltura";
            this.eblAltura.Size = new System.Drawing.Size(47, 16);
            this.eblAltura.TabIndex = 1;
            this.eblAltura.Text = "Altura";
            // 
            // eblVolume
            // 
            this.eblVolume.AutoSize = true;
            this.eblVolume.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.eblVolume.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eblVolume.ForeColor = System.Drawing.Color.Black;
            this.eblVolume.Location = new System.Drawing.Point(19, 105);
            this.eblVolume.Name = "eblVolume";
            this.eblVolume.Size = new System.Drawing.Size(56, 16);
            this.eblVolume.TabIndex = 2;
            this.eblVolume.Text = "Volume";
            // 
            // txtRaio
            // 
            this.txtRaio.BackColor = System.Drawing.SystemColors.Window;
            this.txtRaio.Location = new System.Drawing.Point(83, 19);
            this.txtRaio.Name = "txtRaio";
            this.txtRaio.Size = new System.Drawing.Size(209, 20);
            this.txtRaio.TabIndex = 3;
            // 
            // txtAltura
            // 
            this.txtAltura.BackColor = System.Drawing.SystemColors.Window;
            this.txtAltura.Location = new System.Drawing.Point(83, 61);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(209, 20);
            this.txtAltura.TabIndex = 4;
            // 
            // txtVolume
            // 
            this.txtVolume.BackColor = System.Drawing.SystemColors.Window;
            this.txtVolume.Enabled = false;
            this.txtVolume.Location = new System.Drawing.Point(83, 102);
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.Size = new System.Drawing.Size(209, 20);
            this.txtVolume.TabIndex = 5;
            this.txtVolume.TextChanged += new System.EventHandler(this.txtVolume_TextChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.White;
            this.btnCalcular.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.Black;
            this.btnCalcular.Location = new System.Drawing.Point(19, 143);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(87, 32);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.White;
            this.btnLimpar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpar.Location = new System.Drawing.Point(112, 143);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(87, 32);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.White;
            this.btnSair.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Black;
            this.btnSair.Location = new System.Drawing.Point(205, 143);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(87, 32);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(316, 195);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtVolume);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtRaio);
            this.Controls.Add(this.eblVolume);
            this.Controls.Add(this.eblAltura);
            this.Controls.Add(this.eblRaio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label eblRaio;
        private System.Windows.Forms.Label eblAltura;
        private System.Windows.Forms.Label eblVolume;
        private System.Windows.Forms.TextBox txtRaio;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtVolume;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
    }
}

