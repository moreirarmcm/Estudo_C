namespace TesteSQL
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
            this.btnTeste = new System.Windows.Forms.Button();
            this.dataTeste = new System.Windows.Forms.DataGridView();
            this.lblTeste = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataTeste)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTeste
            // 
            this.btnTeste.Location = new System.Drawing.Point(277, 355);
            this.btnTeste.Name = "btnTeste";
            this.btnTeste.Size = new System.Drawing.Size(204, 71);
            this.btnTeste.TabIndex = 0;
            this.btnTeste.Text = "Teste";
            this.btnTeste.UseVisualStyleBackColor = true;
            this.btnTeste.Click += new System.EventHandler(this.btnTeste_Click);
            // 
            // dataTeste
            // 
            this.dataTeste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTeste.Location = new System.Drawing.Point(22, 23);
            this.dataTeste.Name = "dataTeste";
            this.dataTeste.RowHeadersWidth = 51;
            this.dataTeste.RowTemplate.Height = 24;
            this.dataTeste.Size = new System.Drawing.Size(727, 206);
            this.dataTeste.TabIndex = 1;
            // 
            // lblTeste
            // 
            this.lblTeste.Location = new System.Drawing.Point(22, 243);
            this.lblTeste.Name = "lblTeste";
            this.lblTeste.Size = new System.Drawing.Size(727, 82);
            this.lblTeste.TabIndex = 2;
            this.lblTeste.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTeste);
            this.Controls.Add(this.dataTeste);
            this.Controls.Add(this.btnTeste);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataTeste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTeste;
        private System.Windows.Forms.DataGridView dataTeste;
        private System.Windows.Forms.Label lblTeste;
    }
}

