using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_10___Tela_de_login
{
    public partial class TelaCadastroProduto : Form
    {
        public TelaCadastroProduto()
        {
            InitializeComponent();
            btnSalvarProduto.Click += btnSalvarProduto_Click;
        }

        public class Produto
        {
            public string Codigo { get; set; }
            public string NomeProduto { get; set; }
            public decimal Preco { get; set; }
        }

        public static class ProdutoRepository
        {
            public static List<Produto> Produtos = new List<Produto>();
        }

        private void txtNomeProduto_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnSalvarProduto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) ||
                string.IsNullOrWhiteSpace(txtNomeProduto.Text) ||
                string.IsNullOrWhiteSpace(txtPreco.Text))
            {
                MessageBox.Show("Todos os campos devem ser preenchidos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Criar um novo produto
                Produto novoProduto = new Produto
                {
                    Codigo = txtCodigo.Text,
                    NomeProduto = txtNomeProduto.Text,
                    Preco = decimal.Parse(txtPreco.Text)
                };

                // Adicionar o produto à lista
                ProdutoRepository.Produtos.Add(novoProduto);

                MessageBox.Show("Produto salvo com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
