namespace BaseKarate
{
    partial class FormListagem
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
            label1 = new Label();
            dataLista = new DataGridView();
            CodigoAluno = new DataGridViewTextBoxColumn();
            NomeAluno = new DataGridViewTextBoxColumn();
            cpfAluno = new DataGridViewTextBoxColumn();
            Graduacao = new DataGridViewTextBoxColumn();
            Nascimento = new DataGridViewTextBoxColumn();
            EnderecoAluno = new DataGridViewTextBoxColumn();
            ContatoAluno = new DataGridViewTextBoxColumn();
            NomeResponsavel = new DataGridViewTextBoxColumn();
            ContatoResponsavel = new DataGridViewTextBoxColumn();
            cpfResponsavel = new DataGridViewTextBoxColumn();
            Parentesco = new DataGridViewTextBoxColumn();
            Criacao = new DataGridViewTextBoxColumn();
            btnPesquisar = new Button();
            txtConsulta = new TextBox();
            btnAtualizar = new Button();
            label2 = new Label();
            btnExcluir = new Button();
            ((System.ComponentModel.ISupportInitialize)dataLista).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 38);
            label1.Name = "label1";
            label1.Size = new Size(264, 50);
            label1.TabIndex = 3;
            label1.Text = "Procurar por nome, CPF ou matrícula:";
            label1.Click += label1_Click;
            // 
            // dataLista
            // 
            dataLista.AllowUserToOrderColumns = true;
            dataLista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataLista.Columns.AddRange(new DataGridViewColumn[] { CodigoAluno, NomeAluno, cpfAluno, Graduacao, Nascimento, EnderecoAluno, ContatoAluno, NomeResponsavel, ContatoResponsavel, cpfResponsavel, Parentesco, Criacao });
            dataLista.Location = new Point(12, 91);
            dataLista.Name = "dataLista";
            dataLista.RowHeadersWidth = 51;
            dataLista.Size = new Size(992, 366);
            dataLista.TabIndex = 4;
            // 
            // CodigoAluno
            // 
            CodigoAluno.HeaderText = "Matrícula";
            CodigoAluno.MinimumWidth = 6;
            CodigoAluno.Name = "CodigoAluno";
            // 
            // NomeAluno
            // 
            NomeAluno.HeaderText = "Nome";
            NomeAluno.MinimumWidth = 6;
            NomeAluno.Name = "NomeAluno";
            NomeAluno.Width = 79;
            // 
            // cpfAluno
            // 
            cpfAluno.HeaderText = "CPF";
            cpfAluno.MinimumWidth = 6;
            cpfAluno.Name = "cpfAluno";
            cpfAluno.Width = 62;
            // 
            // Graduacao
            // 
            Graduacao.HeaderText = "Graduação";
            Graduacao.MinimumWidth = 6;
            Graduacao.Name = "Graduacao";
            Graduacao.Width = 110;
            // 
            // Nascimento
            // 
            Nascimento.HeaderText = "Data de Nascimento";
            Nascimento.MinimumWidth = 6;
            Nascimento.Name = "Nascimento";
            Nascimento.Width = 159;
            // 
            // EnderecoAluno
            // 
            EnderecoAluno.HeaderText = "Endereço";
            EnderecoAluno.MinimumWidth = 6;
            EnderecoAluno.Name = "EnderecoAluno";
            // 
            // ContatoAluno
            // 
            ContatoAluno.HeaderText = "Contato";
            ContatoAluno.MinimumWidth = 6;
            ContatoAluno.Name = "ContatoAluno";
            ContatoAluno.Width = 91;
            // 
            // NomeResponsavel
            // 
            NomeResponsavel.HeaderText = "Nome do Responsável";
            NomeResponsavel.MinimumWidth = 6;
            NomeResponsavel.Name = "NomeResponsavel";
            NomeResponsavel.Width = 171;
            // 
            // ContatoResponsavel
            // 
            ContatoResponsavel.HeaderText = "Contato do Responsável";
            ContatoResponsavel.MinimumWidth = 6;
            ContatoResponsavel.Name = "ContatoResponsavel";
            ContatoResponsavel.Width = 182;
            // 
            // cpfResponsavel
            // 
            cpfResponsavel.HeaderText = "CPF do Responsável";
            cpfResponsavel.MinimumWidth = 6;
            cpfResponsavel.Name = "cpfResponsavel";
            cpfResponsavel.Width = 155;
            // 
            // Parentesco
            // 
            Parentesco.HeaderText = "Parentesco";
            Parentesco.MinimumWidth = 6;
            Parentesco.Name = "Parentesco";
            Parentesco.Width = 109;
            // 
            // Criacao
            // 
            Criacao.HeaderText = "Data de Criação";
            Criacao.MinimumWidth = 6;
            Criacao.Name = "Criacao";
            Criacao.Width = 133;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(811, 38);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(148, 32);
            btnPesquisar.TabIndex = 5;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // txtConsulta
            // 
            txtConsulta.Location = new Point(270, 37);
            txtConsulta.Multiline = true;
            txtConsulta.Name = "txtConsulta";
            txtConsulta.Size = new Size(506, 32);
            txtConsulta.TabIndex = 6;
            txtConsulta.TextChanged += txtConsulta_TextChanged;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(62, 517);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(148, 54);
            btnAtualizar.TabIndex = 7;
            btnAtualizar.Text = "Alterar dados do aluno selecionado";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 473);
            label2.Name = "label2";
            label2.Size = new Size(555, 50);
            label2.TabIndex = 8;
            label2.Text = "Com um registro selecionado (acima), opte por uma das alternativas abaixo:";
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(235, 517);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(148, 54);
            btnExcluir.TabIndex = 9;
            btnExcluir.Text = "Excluir aluno selecionado";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += button1_Click;
            // 
            // FormListagem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1271, 740);
            Controls.Add(btnExcluir);
            Controls.Add(label2);
            Controls.Add(btnAtualizar);
            Controls.Add(txtConsulta);
            Controls.Add(btnPesquisar);
            Controls.Add(dataLista);
            Controls.Add(label1);
            Name = "FormListagem";
            Text = "FormListagem";
            ((System.ComponentModel.ISupportInitialize)dataLista).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private DataGridView dataLista;
        private DataGridViewTextBoxColumn CodigoAluno;
        private DataGridViewTextBoxColumn NomeAluno;
        private DataGridViewTextBoxColumn cpfAluno;
        private DataGridViewTextBoxColumn Graduacao;
        private DataGridViewTextBoxColumn Nascimento;
        private DataGridViewTextBoxColumn EnderecoAluno;
        private DataGridViewTextBoxColumn ContatoAluno;
        private DataGridViewTextBoxColumn NomeResponsavel;
        private DataGridViewTextBoxColumn ContatoResponsavel;
        private DataGridViewTextBoxColumn cpfResponsavel;
        private DataGridViewTextBoxColumn Parentesco;
        private DataGridViewTextBoxColumn Criacao;
        private Button btnPesquisar;
        private TextBox txtConsulta;
        private Button btnAtualizar;
        private Label label2;
        private Button btnExcluir;
    }
}