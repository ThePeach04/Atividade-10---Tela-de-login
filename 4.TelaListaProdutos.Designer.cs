namespace Atividade_10___Tela_de_login
{
    partial class TelaListaProdutos
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

                dgvProdutos = new DataGridView();
                ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
                SuspendLayout();
                dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                dgvProdutos.Location = new Point(12, 12);
                dgvProdutos.Name = "dgvProdutos";
                dgvProdutos.Size = new Size(240, 150);
                dgvProdutos.TabIndex = 0;
                dgvProdutos.CellContentClick += dvgProdutos_CellContentClick;
                // 
                // TelaListaProdutos
                // 
                AutoScaleDimensions = new SizeF(7F, 15F);
                AutoScaleMode = AutoScaleMode.Font;
                ClientSize = new Size(265, 173);
                Controls.Add(dgvProdutos);
                Name = "TelaListaProdutos";
                Text = "TelaListaProdutos";
                Load += TelaListaProdutos_Load; // Associar o evento Load aqui
                ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
                ResumeLayout(false);
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
            dgvProdutos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            SuspendLayout();
            // 
            // dgvProdutos
            // 
            dgvProdutos.BackgroundColor = Color.LightGray;
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Location = new Point(14, 14);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.Size = new Size(352, 212);
            dgvProdutos.TabIndex = 0;
            dgvProdutos.CellContentClick += dvgProdutos_CellContentClick;
            // 
            // TelaListaProdutos
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 237);
            Controls.Add(dgvProdutos);
            Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "TelaListaProdutos";
            Text = "Tela de Lista de Produtos";
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProdutos;
    }
}