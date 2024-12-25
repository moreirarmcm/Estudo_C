namespace BaseKarate
{
    partial class FormMenu
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
            btnCadastrar = new Button();
            btnListarAlunos = new Button();
            lblResultado = new Label();
            btnEncerrar = new Button();
            SuspendLayout();
            // 
            // btnCadastrar
            // 
            btnCadastrar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrar.Location = new Point(69, 123);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(151, 64);
            btnCadastrar.TabIndex = 0;
            btnCadastrar.Text = "Cadastrar Aluno";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnListarAlunos
            // 
            btnListarAlunos.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnListarAlunos.Location = new Point(69, 213);
            btnListarAlunos.Name = "btnListarAlunos";
            btnListarAlunos.Size = new Size(151, 64);
            btnListarAlunos.TabIndex = 1;
            btnListarAlunos.Text = "Ver alunos";
            btnListarAlunos.UseVisualStyleBackColor = true;
            btnListarAlunos.Click += btnListarAlunos_Click;
            // 
            // lblResultado
            // 
            lblResultado.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(31, 59);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(225, 40);
            lblResultado.TabIndex = 6;
            lblResultado.Text = "O que você deseja fazer?";
            // 
            // btnEncerrar
            // 
            btnEncerrar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEncerrar.Location = new Point(69, 301);
            btnEncerrar.Name = "btnEncerrar";
            btnEncerrar.Size = new Size(151, 64);
            btnEncerrar.TabIndex = 7;
            btnEncerrar.Text = "Encerrar ";
            btnEncerrar.UseVisualStyleBackColor = true;
            btnEncerrar.Click += btnEncerrar_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(286, 417);
            Controls.Add(btnEncerrar);
            Controls.Add(lblResultado);
            Controls.Add(btnListarAlunos);
            Controls.Add(btnCadastrar);
            Name = "FormMenu";
            Text = "FormMenu";
            Load += FormMenu_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnCadastrar;
        private Button btnListarAlunos;
        private Label lblResultado;
        private Button btnEncerrar;
    }
}