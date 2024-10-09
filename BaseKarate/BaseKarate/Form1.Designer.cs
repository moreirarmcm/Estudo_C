namespace BaseKarate
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTeste = new Label();
            txtTeste = new TextBox();
            btnMenu = new Button();
            SuspendLayout();
            // 
            // lblTeste
            // 
            lblTeste.BackColor = SystemColors.ButtonFace;
            lblTeste.BorderStyle = BorderStyle.FixedSingle;
            lblTeste.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTeste.ForeColor = SystemColors.ActiveCaptionText;
            lblTeste.Location = new Point(33, 23);
            lblTeste.Name = "lblTeste";
            lblTeste.Size = new Size(736, 113);
            lblTeste.TabIndex = 1;
            lblTeste.Text = "label1";
            // 
            // txtTeste
            // 
            txtTeste.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTeste.Location = new Point(33, 168);
            txtTeste.Name = "txtTeste";
            txtTeste.Size = new Size(736, 31);
            txtTeste.TabIndex = 2;
            // 
            // btnMenu
            // 
            btnMenu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMenu.Location = new Point(323, 274);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(189, 59);
            btnMenu.TabIndex = 3;
            btnMenu.Text = "Acessar o Menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMenu);
            Controls.Add(txtTeste);
            Controls.Add(lblTeste);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTeste;
        private TextBox txtTeste;
        private Button btnMenu;
    }
}
