namespace BaseKarate
{
    partial class FormCadastramento
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
            txtNomeAluno = new TextBox();
            txtCPF = new TextBox();
            txtContatoAluno = new TextBox();
            txtEndereco = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            radioMasculino = new RadioButton();
            radioFeminino = new RadioButton();
            txtNomeResponsavel = new TextBox();
            txtContatoResponsavel = new TextBox();
            txtCPFResponsavel = new TextBox();
            groupBox1 = new GroupBox();
            comboGraduacao = new ComboBox();
            comboParentesco = new ComboBox();
            btnInsert = new Button();
            btnLimpar = new Button();
            timeDataNascimento = new DateTimePicker();
            timeInicio = new DateTimePicker();
            btnVoltar = new Button();
            lblTeste = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtNomeAluno
            // 
            txtNomeAluno.Location = new Point(197, 50);
            txtNomeAluno.Name = "txtNomeAluno";
            txtNomeAluno.Size = new Size(448, 27);
            txtNomeAluno.TabIndex = 0;
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(197, 86);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(448, 27);
            txtCPF.TabIndex = 1;
            // 
            // txtContatoAluno
            // 
            txtContatoAluno.Location = new Point(197, 240);
            txtContatoAluno.Name = "txtContatoAluno";
            txtContatoAluno.Size = new Size(448, 27);
            txtContatoAluno.TabIndex = 4;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(197, 207);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(448, 27);
            txtEndereco.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 55);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 7;
            label1.Text = "Nome do aluno:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 128);
            label2.Name = "label2";
            label2.Size = new Size(145, 20);
            label2.TabIndex = 8;
            label2.Text = "Data de nascimento:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 207);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 9;
            label3.Text = "Endereço:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 245);
            label4.Name = "label4";
            label4.Size = new Size(144, 20);
            label4.TabIndex = 10;
            label4.Text = "Telefone/WhatsApp:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 280);
            label5.Name = "label5";
            label5.Size = new Size(116, 20);
            label5.TabIndex = 11;
            label5.Text = "Início no Karatê:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 319);
            label6.Name = "label6";
            label6.Size = new Size(84, 20);
            label6.TabIndex = 12;
            label6.Text = "Graduação:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 168);
            label7.Name = "label7";
            label7.Size = new Size(44, 20);
            label7.TabIndex = 13;
            label7.Text = "Sexo:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(20, 380);
            label8.Name = "label8";
            label8.Size = new Size(161, 20);
            label8.TabIndex = 14;
            label8.Text = "Nome do Responsável:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(22, 417);
            label9.Name = "label9";
            label9.Size = new Size(173, 20);
            label9.TabIndex = 15;
            label9.Text = "Contato do Responsável:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(26, 487);
            label10.Name = "label10";
            label10.Size = new Size(83, 20);
            label10.TabIndex = 16;
            label10.Text = "Parentesco:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(23, 450);
            label11.Name = "label11";
            label11.Size = new Size(144, 20);
            label11.TabIndex = 17;
            label11.Text = "CPF do Responsável:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(25, 95);
            label12.Name = "label12";
            label12.Size = new Size(36, 20);
            label12.TabIndex = 18;
            label12.Text = "CPF:";
            label12.Click += label12_Click;
            // 
            // radioMasculino
            // 
            radioMasculino.AutoSize = true;
            radioMasculino.Location = new Point(17, 19);
            radioMasculino.Name = "radioMasculino";
            radioMasculino.Size = new Size(97, 24);
            radioMasculino.TabIndex = 19;
            radioMasculino.TabStop = true;
            radioMasculino.Text = "Masculino";
            radioMasculino.UseVisualStyleBackColor = true;
            radioMasculino.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioFeminino
            // 
            radioFeminino.AutoSize = true;
            radioFeminino.Location = new Point(129, 19);
            radioFeminino.Name = "radioFeminino";
            radioFeminino.Size = new Size(91, 24);
            radioFeminino.TabIndex = 20;
            radioFeminino.TabStop = true;
            radioFeminino.Text = "Feminino";
            radioFeminino.UseVisualStyleBackColor = true;
            // 
            // txtNomeResponsavel
            // 
            txtNomeResponsavel.Location = new Point(197, 375);
            txtNomeResponsavel.Name = "txtNomeResponsavel";
            txtNomeResponsavel.Size = new Size(448, 27);
            txtNomeResponsavel.TabIndex = 29;
            // 
            // txtContatoResponsavel
            // 
            txtContatoResponsavel.Location = new Point(197, 408);
            txtContatoResponsavel.Name = "txtContatoResponsavel";
            txtContatoResponsavel.Size = new Size(448, 27);
            txtContatoResponsavel.TabIndex = 30;
            // 
            // txtCPFResponsavel
            // 
            txtCPFResponsavel.Location = new Point(197, 445);
            txtCPFResponsavel.Name = "txtCPFResponsavel";
            txtCPFResponsavel.Size = new Size(448, 27);
            txtCPFResponsavel.TabIndex = 31;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioMasculino);
            groupBox1.Controls.Add(radioFeminino);
            groupBox1.Location = new Point(201, 152);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(258, 49);
            groupBox1.TabIndex = 32;
            groupBox1.TabStop = false;
            // 
            // comboGraduacao
            // 
            comboGraduacao.FormattingEnabled = true;
            comboGraduacao.Items.AddRange(new object[] { "Branca (7° Kyu)", "Amarela (6° Kyu)", "Vermelha (5° Kyu)", "Laranja (4° Kyu)", "Verde (3° Kyu)", "Roxa (2° Kyu)", "Marrom (1° Kyu)", "Preta (1° Dan)" });
            comboGraduacao.Location = new Point(197, 317);
            comboGraduacao.Name = "comboGraduacao";
            comboGraduacao.Size = new Size(151, 28);
            comboGraduacao.TabIndex = 35;
            // 
            // comboParentesco
            // 
            comboParentesco.FormattingEnabled = true;
            comboParentesco.Items.AddRange(new object[] { "Pai/Mãe", "Avô/Avó", "Irmão/Irmã", "Tio/Tia" });
            comboParentesco.Location = new Point(197, 485);
            comboParentesco.Name = "comboParentesco";
            comboParentesco.Size = new Size(151, 28);
            comboParentesco.TabIndex = 36;
            // 
            // btnInsert
            // 
            btnInsert.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInsert.Location = new Point(113, 594);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(392, 65);
            btnInsert.TabIndex = 37;
            btnInsert.Text = "Cadastrar novo aluno";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnLimpar.Location = new Point(151, 674);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(149, 32);
            btnLimpar.TabIndex = 38;
            btnLimpar.Text = "Limpar campos";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // timeDataNascimento
            // 
            timeDataNascimento.Location = new Point(197, 123);
            timeDataNascimento.Name = "timeDataNascimento";
            timeDataNascimento.Size = new Size(348, 27);
            timeDataNascimento.TabIndex = 40;
            timeDataNascimento.Value = new DateTime(2024, 10, 5, 23, 16, 19, 0);
            // 
            // timeInicio
            // 
            timeInicio.Format = DateTimePickerFormat.Custom;
            timeInicio.Location = new Point(197, 275);
            timeInicio.Name = "timeInicio";
            timeInicio.Size = new Size(348, 27);
            timeInicio.TabIndex = 41;
            timeInicio.Value = new DateTime(2024, 10, 5, 23, 16, 19, 0);
            // 
            // btnVoltar
            // 
            btnVoltar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnVoltar.Location = new Point(321, 674);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(149, 32);
            btnVoltar.TabIndex = 42;
            btnVoltar.Text = "Voltar ao menu";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // lblTeste
            // 
            lblTeste.Location = new Point(26, 527);
            lblTeste.Name = "lblTeste";
            lblTeste.Size = new Size(619, 64);
            lblTeste.TabIndex = 43;
            lblTeste.Text = "lblTeste";
            // 
            // FormCadastramento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 730);
            Controls.Add(lblTeste);
            Controls.Add(btnVoltar);
            Controls.Add(timeInicio);
            Controls.Add(timeDataNascimento);
            Controls.Add(btnLimpar);
            Controls.Add(btnInsert);
            Controls.Add(comboParentesco);
            Controls.Add(comboGraduacao);
            Controls.Add(groupBox1);
            Controls.Add(txtCPFResponsavel);
            Controls.Add(txtContatoResponsavel);
            Controls.Add(txtNomeResponsavel);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtEndereco);
            Controls.Add(txtContatoAluno);
            Controls.Add(txtCPF);
            Controls.Add(txtNomeAluno);
            Name = "FormCadastramento";
            Text = "FormCadastramento";
            Load += FormCadastramento_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNomeAluno;
        private TextBox txtCPF;
        private TextBox txtContatoAluno;
        private TextBox txtEndereco;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private RadioButton radioMasculino;
        private RadioButton radioFeminino;
        private TextBox txtNomeResponsavel;
        private TextBox txtContatoResponsavel;
        private TextBox txtCPFResponsavel;
        private GroupBox groupBox1;
        private ComboBox comboGraduacao;
        private ComboBox comboParentesco;
        private Button btnInsert;
        private Button btnLimpar;
        private DateTimePicker timeDataNascimento;
        private DateTimePicker timeInicio;
        private Button btnVoltar;
        private Label lblTeste;
    }
}