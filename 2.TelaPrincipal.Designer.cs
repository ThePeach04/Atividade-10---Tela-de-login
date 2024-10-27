namespace Atividade_10___Tela_de_login
{
    partial class TelaPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
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
            btnCadastroProduto = new Button();
            btnListarProdutos = new Button();
            SuspendLayout();
            // 
            // btnCadastroProduto
            // 
            btnCadastroProduto.BackColor = Color.DarkBlue;
            btnCadastroProduto.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastroProduto.ForeColor = Color.White;
            btnCadastroProduto.Location = new Point(43, 34);
            btnCadastroProduto.Name = "btnCadastroProduto";
            btnCadastroProduto.Size = new Size(254, 37);
            btnCadastroProduto.TabIndex = 0;
            btnCadastroProduto.Text = "Cadastro de Produtos";
            btnCadastroProduto.UseVisualStyleBackColor = false;
            btnCadastroProduto.Click += btnCadastroProduto_Click;
            // 
            // btnListarProdutos
            // 
            btnListarProdutos.BackColor = Color.DarkBlue;
            btnListarProdutos.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnListarProdutos.ForeColor = Color.White;
            btnListarProdutos.Location = new Point(69, 95);
            btnListarProdutos.Name = "btnListarProdutos";
            btnListarProdutos.Size = new Size(193, 38);
            btnListarProdutos.TabIndex = 1;
            btnListarProdutos.Text = "Listar Produtos";
            btnListarProdutos.UseVisualStyleBackColor = false;
            btnListarProdutos.Click += btnListarProdutos_Click;
            // 
            // TelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(323, 191);
            Controls.Add(btnListarProdutos);
            Controls.Add(btnCadastroProduto);
            Name = "TelaPrincipal";
            Text = "Tela Principal";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCadastroProduto;
        private Button btnListarProdutos;
    }
}