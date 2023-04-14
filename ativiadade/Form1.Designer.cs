namespace ativiadade
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
            this.bntenviar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtdolar = new System.Windows.Forms.TextBox();
            this.txtreal = new System.Windows.Forms.TextBox();
            this.DOLLAR = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bntenviar
            // 
            this.bntenviar.Location = new System.Drawing.Point(39, 100);
            this.bntenviar.Name = "bntenviar";
            this.bntenviar.Size = new System.Drawing.Size(75, 23);
            this.bntenviar.TabIndex = 0;
            this.bntenviar.Text = "enviar";
            this.bntenviar.UseVisualStyleBackColor = true;
            this.bntenviar.Click += new System.EventHandler(this.bntenviar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(160, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "limpar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtdolar
            // 
            this.txtdolar.Location = new System.Drawing.Point(58, 35);
            this.txtdolar.Name = "txtdolar";
            this.txtdolar.Size = new System.Drawing.Size(191, 20);
            this.txtdolar.TabIndex = 2;
            // 
            // txtreal
            // 
            this.txtreal.Location = new System.Drawing.Point(58, 61);
            this.txtreal.Name = "txtreal";
            this.txtreal.Size = new System.Drawing.Size(191, 20);
            this.txtreal.TabIndex = 3;
            // 
            // DOLLAR
            // 
            this.DOLLAR.AutoSize = true;
            this.DOLLAR.Location = new System.Drawing.Point(3, 35);
            this.DOLLAR.Name = "DOLLAR";
            this.DOLLAR.Size = new System.Drawing.Size(50, 13);
            this.DOLLAR.TabIndex = 4;
            this.DOLLAR.Text = "DOLLAR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "REAL";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(261, 135);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DOLLAR);
            this.Controls.Add(this.txtreal);
            this.Controls.Add(this.txtdolar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bntenviar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntenviar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtdolar;
        private System.Windows.Forms.TextBox txtreal;
        private System.Windows.Forms.Label DOLLAR;
        private System.Windows.Forms.Label label2;
    }
}

