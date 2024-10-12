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
            dataLista = new DataGridView();
            CodigoAluno = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Graduacao = new DataGridViewTextBoxColumn();
            Nascimento = new DataGridViewTextBoxColumn();
            Endereco = new DataGridViewTextBoxColumn();
            Contato = new DataGridViewTextBoxColumn();
            NomeResponsavel = new DataGridViewTextBoxColumn();
            Parentesco = new DataGridViewTextBoxColumn();
            ContatoResponsavel = new DataGridViewTextBoxColumn();
            Criacao = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataLista).BeginInit();
            SuspendLayout();
            // 
            // dataLista
            // 
            dataLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataLista.Columns.AddRange(new DataGridViewColumn[] { CodigoAluno, Nome, Graduacao, Nascimento, Endereco, Contato, NomeResponsavel, Parentesco, ContatoResponsavel, Criacao });
            dataLista.Location = new Point(12, 153);
            dataLista.Name = "dataLista";
            dataLista.RowHeadersWidth = 51;
            dataLista.Size = new Size(918, 283);
            dataLista.TabIndex = 0;
            dataLista.CellContentClick += dataLista_CellContentClick;
            // 
            // CodigoAluno
            // 
            CodigoAluno.HeaderText = "Matrícula";
            CodigoAluno.MinimumWidth = 6;
            CodigoAluno.Name = "CodigoAluno";
            CodigoAluno.Width = 125;
            // 
            // Nome
            // 
            Nome.HeaderText = "Nome do Aluno";
            Nome.MinimumWidth = 6;
            Nome.Name = "Nome";
            Nome.Width = 125;
            // 
            // Graduacao
            // 
            Graduacao.HeaderText = "Graduação";
            Graduacao.MinimumWidth = 6;
            Graduacao.Name = "Graduacao";
            Graduacao.Width = 125;
            // 
            // Nascimento
            // 
            Nascimento.HeaderText = "Data de Nascimento";
            Nascimento.MinimumWidth = 6;
            Nascimento.Name = "Nascimento";
            Nascimento.Width = 125;
            // 
            // Endereco
            // 
            Endereco.HeaderText = "Endereço";
            Endereco.MinimumWidth = 6;
            Endereco.Name = "Endereco";
            Endereco.Width = 125;
            // 
            // Contato
            // 
            Contato.HeaderText = "Contado do Aluno";
            Contato.MinimumWidth = 6;
            Contato.Name = "Contato";
            Contato.Width = 125;
            // 
            // NomeResponsavel
            // 
            NomeResponsavel.HeaderText = "Responsável";
            NomeResponsavel.MinimumWidth = 6;
            NomeResponsavel.Name = "NomeResponsavel";
            NomeResponsavel.Width = 125;
            // 
            // Parentesco
            // 
            Parentesco.HeaderText = "Parentesco";
            Parentesco.MinimumWidth = 6;
            Parentesco.Name = "Parentesco";
            Parentesco.Width = 125;
            // 
            // ContatoResponsavel
            // 
            ContatoResponsavel.HeaderText = "Contato do Responsável";
            ContatoResponsavel.MinimumWidth = 6;
            ContatoResponsavel.Name = "ContatoResponsavel";
            ContatoResponsavel.Width = 125;
            // 
            // Criacao
            // 
            Criacao.HeaderText = "Data de Criação";
            Criacao.MinimumWidth = 6;
            Criacao.Name = "Criacao";
            Criacao.Width = 125;
            // 
            // FormListagem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 448);
            Controls.Add(dataLista);
            Name = "FormListagem";
            Text = "FormListagem";
            ((System.ComponentModel.ISupportInitialize)dataLista).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataLista;
        private DataGridViewTextBoxColumn CodigoAluno;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Graduacao;
        private DataGridViewTextBoxColumn Nascimento;
        private DataGridViewTextBoxColumn Endereco;
        private DataGridViewTextBoxColumn Contato;
        private DataGridViewTextBoxColumn NomeResponsavel;
        private DataGridViewTextBoxColumn Parentesco;
        private DataGridViewTextBoxColumn ContatoResponsavel;
        private DataGridViewTextBoxColumn Criacao;
    }
}