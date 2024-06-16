namespace Formulario
{
    partial class FormMain
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnSgundo = new System.Windows.Forms.Button();
            this.btnSegundoThread = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(13, 11);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(1035, 144);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Principal";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSgundo
            // 
            this.btnSgundo.Location = new System.Drawing.Point(98, 295);
            this.btnSgundo.Name = "btnSgundo";
            this.btnSgundo.Size = new System.Drawing.Size(162, 61);
            this.btnSgundo.TabIndex = 1;
            this.btnSgundo.Text = "Segundo formulário";
            this.btnSgundo.UseVisualStyleBackColor = true;
            this.btnSgundo.Click += new System.EventHandler(this.btnSgundo_Click);
            // 
            // btnSegundoThread
            // 
            this.btnSegundoThread.Location = new System.Drawing.Point(288, 298);
            this.btnSegundoThread.Name = "btnSegundoThread";
            this.btnSegundoThread.Size = new System.Drawing.Size(147, 54);
            this.btnSegundoThread.TabIndex = 2;
            this.btnSegundoThread.Text = "Segundo formulário por thread";
            this.btnSegundoThread.UseVisualStyleBackColor = true;
            this.btnSegundoThread.Click += new System.EventHandler(this.btnSegundoThread_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnSegundoThread);
            this.Controls.Add(this.btnSgundo);
            this.Controls.Add(this.lblTitulo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário Principal";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnSgundo;
        private System.Windows.Forms.Button btnSegundoThread;
    }
}