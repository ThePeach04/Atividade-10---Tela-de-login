namespace Atividade_10___Tela_de_login
{
    partial class TelaCadastroProduto
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
            lblCodigo = new Label();
            lblNomeProduto = new Label();
            txtCodigo = new TextBox();
            txtNomeProduto = new TextBox();
            txtPreco = new TextBox();
            lblPreco = new Label();
            btnSalvarProduto = new Button();
            SuspendLayout();
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Arial Narrow", 12F);
            lblCodigo.Location = new Point(16, 21);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(53, 20);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Código";
            // 
            // lblNomeProduto
            // 
            lblNomeProduto.AutoSize = true;
            lblNomeProduto.Font = new Font("Arial Narrow", 12F);
            lblNomeProduto.Location = new Point(14, 58);
            lblNomeProduto.Name = "lblNomeProduto";
            lblNomeProduto.Size = new Size(96, 20);
            lblNomeProduto.TabIndex = 1;
            lblNomeProduto.Text = "Nome Produto";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(133, 18);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 2;
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.Location = new Point(133, 59);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(100, 23);
            txtNomeProduto.TabIndex = 3;
            txtNomeProduto.TextChanged += txtNomeProduto_TextChanged;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(133, 104);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(100, 23);
            txtPreco.TabIndex = 4;
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Font = new Font("Arial Narrow", 12F);
            lblPreco.Location = new Point(16, 104);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(45, 20);
            lblPreco.TabIndex = 5;
            lblPreco.Text = "Preço";
            // 
            // btnSalvarProduto
            // 
            btnSalvarProduto.Location = new Point(147, 155);
            btnSalvarProduto.Name = "btnSalvarProduto";
            btnSalvarProduto.Size = new Size(75, 23);
            btnSalvarProduto.TabIndex = 6;
            btnSalvarProduto.Text = "Salvar";
            btnSalvarProduto.UseVisualStyleBackColor = true;
            // 
            // TelaCadastroProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(245, 188);
            Controls.Add(btnSalvarProduto);
            Controls.Add(lblPreco);
            Controls.Add(txtPreco);
            Controls.Add(txtNomeProduto);
            Controls.Add(txtCodigo);
            Controls.Add(lblNomeProduto);
            Controls.Add(lblCodigo);
            Name = "TelaCadastroProduto";
            Text = "Tela de Cadastro de Produto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodigo;
        private Label lblNomeProduto;
        private TextBox txtCodigo;
        private TextBox txtNomeProduto;
        private TextBox txtPreco;
        private Label lblPreco;
        private Button btnSalvarProduto;
        
    }
}