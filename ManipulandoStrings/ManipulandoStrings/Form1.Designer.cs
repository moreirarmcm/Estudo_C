namespace ManipulandoStrings
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
            this.lbl_string = new System.Windows.Forms.Label();
            this.btn_executar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_string
            // 
            this.lbl_string.Location = new System.Drawing.Point(28, 24);
            this.lbl_string.Name = "lbl_string";
            this.lbl_string.Size = new System.Drawing.Size(190, 49);
            this.lbl_string.TabIndex = 0;
            this.lbl_string.Text = "label1";
            // 
            // btn_executar
            // 
            this.btn_executar.Location = new System.Drawing.Point(31, 129);
            this.btn_executar.Name = "btn_executar";
            this.btn_executar.Size = new System.Drawing.Size(113, 43);
            this.btn_executar.TabIndex = 1;
            this.btn_executar.Text = "Executar";
            this.btn_executar.UseVisualStyleBackColor = true;
            this.btn_executar.Click += new System.EventHandler(this.btn_executar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_executar);
            this.Controls.Add(this.lbl_string);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_string;
        private System.Windows.Forms.Button btn_executar;
    }
}

