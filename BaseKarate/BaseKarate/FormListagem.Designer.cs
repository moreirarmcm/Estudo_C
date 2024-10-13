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
            lblTeste = new Label();
            dataLista2 = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataLista2).BeginInit();
            SuspendLayout();
            // 
            // lblTeste
            // 
            lblTeste.Location = new Point(30, 19);
            lblTeste.Name = "lblTeste";
            lblTeste.Size = new Size(774, 114);
            lblTeste.TabIndex = 3;
            lblTeste.Text = "label1";
            // 
            // dataLista2
            // 
            dataLista2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataLista2.Columns.AddRange(new DataGridViewColumn[] { Codigo, Nome });
            dataLista2.Location = new Point(12, 111);
            dataLista2.Name = "dataLista2";
            dataLista2.RowHeadersWidth = 51;
            dataLista2.Size = new Size(918, 188);
            dataLista2.TabIndex = 4;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo";
            Codigo.MinimumWidth = 6;
            Codigo.Name = "Codigo";
            Codigo.Width = 125;
            // 
            // Nome
            // 
            Nome.HeaderText = "Nome";
            Nome.MinimumWidth = 6;
            Nome.Name = "Nome";
            Nome.Width = 125;
            // 
            // FormListagem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 448);
            Controls.Add(dataLista2);
            Controls.Add(lblTeste);
            Name = "FormListagem";
            Text = "FormListagem";
            ((System.ComponentModel.ISupportInitialize)dataLista2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label lblTeste;
        private DataGridView dataLista2;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nome;
    }
}