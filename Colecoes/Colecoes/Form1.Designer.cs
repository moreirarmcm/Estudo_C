﻿namespace Colecoes
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
            this.Lista = new System.Windows.Forms.ListBox();
            this.btnList = new System.Windows.Forms.Button();
            this.btnHashset = new System.Windows.Forms.Button();
            this.btnDictionary = new System.Windows.Forms.Button();
            this.btnSorted = new System.Windows.Forms.Button();
            this.btnSortedSet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lista
            // 
            this.Lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lista.FormattingEnabled = true;
            this.Lista.ItemHeight = 24;
            this.Lista.Location = new System.Drawing.Point(12, 36);
            this.Lista.Name = "Lista";
            this.Lista.Size = new System.Drawing.Size(634, 388);
            this.Lista.TabIndex = 0;
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(652, 36);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(136, 37);
            this.btnList.TabIndex = 1;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnHashset
            // 
            this.btnHashset.Location = new System.Drawing.Point(652, 90);
            this.btnHashset.Name = "btnHashset";
            this.btnHashset.Size = new System.Drawing.Size(136, 37);
            this.btnHashset.TabIndex = 2;
            this.btnHashset.Text = "HashSet";
            this.btnHashset.UseVisualStyleBackColor = true;
            this.btnHashset.Click += new System.EventHandler(this.btnHashset_Click);
            // 
            // btnDictionary
            // 
            this.btnDictionary.Location = new System.Drawing.Point(652, 142);
            this.btnDictionary.Name = "btnDictionary";
            this.btnDictionary.Size = new System.Drawing.Size(136, 37);
            this.btnDictionary.TabIndex = 3;
            this.btnDictionary.Text = "Dictionary";
            this.btnDictionary.UseVisualStyleBackColor = true;
            this.btnDictionary.Click += new System.EventHandler(this.btnDictionary_Click);
            // 
            // btnSorted
            // 
            this.btnSorted.Location = new System.Drawing.Point(651, 197);
            this.btnSorted.Name = "btnSorted";
            this.btnSorted.Size = new System.Drawing.Size(136, 37);
            this.btnSorted.TabIndex = 4;
            this.btnSorted.Text = "Sorted List";
            this.btnSorted.UseVisualStyleBackColor = true;
            this.btnSorted.Click += new System.EventHandler(this.btnSorted_Click);
            // 
            // btnSortedSet
            // 
            this.btnSortedSet.Location = new System.Drawing.Point(652, 250);
            this.btnSortedSet.Name = "btnSortedSet";
            this.btnSortedSet.Size = new System.Drawing.Size(136, 37);
            this.btnSortedSet.TabIndex = 5;
            this.btnSortedSet.Text = "Sorted Set";
            this.btnSortedSet.UseVisualStyleBackColor = true;
            this.btnSortedSet.Click += new System.EventHandler(this.btnSortedSet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 450);
            this.Controls.Add(this.btnSortedSet);
            this.Controls.Add(this.btnSorted);
            this.Controls.Add(this.btnDictionary);
            this.Controls.Add(this.btnHashset);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.Lista);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listas genéricas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Lista;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnHashset;
        private System.Windows.Forms.Button btnDictionary;
        private System.Windows.Forms.Button btnSorted;
        private System.Windows.Forms.Button btnSortedSet;
    }
}

