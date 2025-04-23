namespace projeto_haras_larissa
{
    partial class frmHaras
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
            this.lblApp = new System.Windows.Forms.Label();
            this.txtNumcavalos = new System.Windows.Forms.TextBox();
            this.lblCavalos = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.Sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblApp
            // 
            this.lblApp.AutoSize = true;
            this.lblApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApp.Location = new System.Drawing.Point(76, 34);
            this.lblApp.Name = "lblApp";
            this.lblApp.Size = new System.Drawing.Size(430, 55);
            this.lblApp.TabIndex = 0;
            this.lblApp.Text = "Sistemas de Haras";
            // 
            // txtNumcavalos
            // 
            this.txtNumcavalos.Location = new System.Drawing.Point(67, 244);
            this.txtNumcavalos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNumcavalos.Name = "txtNumcavalos";
            this.txtNumcavalos.Size = new System.Drawing.Size(420, 26);
            this.txtNumcavalos.TabIndex = 1;
            // 
            // lblCavalos
            // 
            this.lblCavalos.AutoSize = true;
            this.lblCavalos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCavalos.Location = new System.Drawing.Point(62, 161);
            this.lblCavalos.Name = "lblCavalos";
            this.lblCavalos.Size = new System.Drawing.Size(444, 30);
            this.lblCavalos.TabIndex = 3;
            this.lblCavalos.Text = "Insira o número de cavalos recebidos:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(62, 346);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(127, 119);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(215, 346);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(124, 119);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // Sair
            // 
            this.Sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sair.Location = new System.Drawing.Point(362, 346);
            this.Sair.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(124, 119);
            this.Sair.TabIndex = 7;
            this.Sair.Text = "Sair";
            this.Sair.UseVisualStyleBackColor = true;
            this.Sair.Click += new System.EventHandler(this.Sair_Click);
            // 
            // frmHaras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(561, 562);
            this.ControlBox = false;
            this.Controls.Add(this.Sair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblCavalos);
            this.Controls.Add(this.txtNumcavalos);
            this.Controls.Add(this.lblApp);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmHaras";
            this.Text = "Sistema de Haras";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblApp;
        private System.Windows.Forms.TextBox txtNumcavalos;
        private System.Windows.Forms.Label lblCavalos;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button Sair;
    }
}

