namespace BibliotecaDigital
{
    partial class FrmAssociacoes
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
            this.cmbLivros = new System.Windows.Forms.ComboBox();
            this.cmbAutores = new System.Windows.Forms.ComboBox();
            this.btnAssociar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.dgvAssociacoes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssociacoes)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbLivros
            // 
            this.cmbLivros.FormattingEnabled = true;
            this.cmbLivros.Location = new System.Drawing.Point(12, 123);
            this.cmbLivros.Name = "cmbLivros";
            this.cmbLivros.Size = new System.Drawing.Size(172, 28);
            this.cmbLivros.TabIndex = 0;
            this.cmbLivros.SelectedIndexChanged += new System.EventHandler(this.cmbLivros_SelectedIndexChanged);
            // 
            // cmbAutores
            // 
            this.cmbAutores.FormattingEnabled = true;
            this.cmbAutores.Location = new System.Drawing.Point(12, 265);
            this.cmbAutores.Name = "cmbAutores";
            this.cmbAutores.Size = new System.Drawing.Size(172, 28);
            this.cmbAutores.TabIndex = 1;
            this.cmbAutores.SelectedIndexChanged += new System.EventHandler(this.cmbAutores_SelectedIndexChanged);
            // 
            // btnAssociar
            // 
            this.btnAssociar.Location = new System.Drawing.Point(293, 364);
            this.btnAssociar.Name = "btnAssociar";
            this.btnAssociar.Size = new System.Drawing.Size(132, 46);
            this.btnAssociar.TabIndex = 2;
            this.btnAssociar.Text = "Associar";
            this.btnAssociar.UseVisualStyleBackColor = true;
            this.btnAssociar.Click += new System.EventHandler(this.btnAssociar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(528, 364);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(132, 46);
            this.btnRemover.TabIndex = 3;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(762, 364);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(132, 46);
            this.btnListar.TabIndex = 4;
            this.btnListar.Text = "Listar por Autor";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // dgvAssociacoes
            // 
            this.dgvAssociacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssociacoes.Location = new System.Drawing.Point(216, 59);
            this.dgvAssociacoes.Name = "dgvAssociacoes";
            this.dgvAssociacoes.RowHeadersWidth = 62;
            this.dgvAssociacoes.RowTemplate.Height = 28;
            this.dgvAssociacoes.Size = new System.Drawing.Size(746, 260);
            this.dgvAssociacoes.TabIndex = 5;
            this.dgvAssociacoes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAssociacoes_CellContentClick);
            // 
            // FrmAssociacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 450);
            this.Controls.Add(this.dgvAssociacoes);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAssociar);
            this.Controls.Add(this.cmbAutores);
            this.Controls.Add(this.cmbLivros);
            this.Name = "FrmAssociacoes";
            this.Text = "FrmAssociacoes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssociacoes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbLivros;
        private System.Windows.Forms.ComboBox cmbAutores;
        private System.Windows.Forms.Button btnAssociar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.DataGridView dgvAssociacoes;
    }
}