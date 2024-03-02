namespace SistemaLogin
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
            this.label_boasVindas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_boasVindas
            // 
            this.label_boasVindas.Font = new System.Drawing.Font("Palatino Linotype", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_boasVindas.Location = new System.Drawing.Point(56, 87);
            this.label_boasVindas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_boasVindas.Name = "label_boasVindas";
            this.label_boasVindas.Size = new System.Drawing.Size(588, 248);
            this.label_boasVindas.TabIndex = 0;
            this.label_boasVindas.Text = "Tela Inicial";
            this.label_boasVindas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label_boasVindas.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 403);
            this.Controls.Add(this.label_boasVindas);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Início";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_boasVindas;
    }
}

