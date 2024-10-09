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
            btnListarResponsaveis = new Button();
            btnConsultar = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            lblResultado = new Label();
            btnEncerrar = new Button();
            SuspendLayout();
            // 
            // btnCadastrar
            // 
            btnCadastrar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrar.Location = new Point(711, 51);
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
            btnListarAlunos.Location = new Point(711, 191);
            btnListarAlunos.Name = "btnListarAlunos";
            btnListarAlunos.Size = new Size(151, 64);
            btnListarAlunos.TabIndex = 1;
            btnListarAlunos.Text = "Listar Alunos";
            btnListarAlunos.UseVisualStyleBackColor = true;
            // 
            // btnListarResponsaveis
            // 
            btnListarResponsaveis.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnListarResponsaveis.Location = new Point(711, 261);
            btnListarResponsaveis.Name = "btnListarResponsaveis";
            btnListarResponsaveis.Size = new Size(151, 64);
            btnListarResponsaveis.TabIndex = 2;
            btnListarResponsaveis.Text = "Listar responsáveis";
            btnListarResponsaveis.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            btnConsultar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConsultar.Location = new Point(711, 121);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(151, 64);
            btnConsultar.TabIndex = 3;
            btnConsultar.Text = "Consultar aluno";
            btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.Location = new Point(711, 335);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(151, 64);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "Editar dados (aluno)";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluir.Location = new Point(711, 405);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(151, 64);
            btnExcluir.TabIndex = 5;
            btnExcluir.Text = "Excluir dados";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // lblResultado
            // 
            lblResultado.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(27, 58);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(627, 84);
            lblResultado.TabIndex = 6;
            lblResultado.Text = "O que você deseja fazer?";
            // 
            // btnEncerrar
            // 
            btnEncerrar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEncerrar.Location = new Point(711, 475);
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
            ClientSize = new Size(888, 591);
            Controls.Add(btnEncerrar);
            Controls.Add(lblResultado);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnConsultar);
            Controls.Add(btnListarResponsaveis);
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
        private Button btnListarResponsaveis;
        private Button btnConsultar;
        private Button btnEditar;
        private Button btnExcluir;
        private Label lblResultado;
        private Button btnEncerrar;
    }
}