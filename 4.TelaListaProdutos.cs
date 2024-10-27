using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Atividade_10___Tela_de_login.TelaCadastroProduto;

namespace Atividade_10___Tela_de_login
{
    public partial class TelaListaProdutos : Form
    {
        public TelaListaProdutos()
        {
            InitializeComponent();
            Load += TelaListaProdutos_Load;
        }

        private void TelaListaProdutos_Load(object sender, EventArgs e)
        {
            dgvProdutos.DataSource = null;
            dgvProdutos.DataSource = ProdutoRepository.Produtos;
        }

        private void dvgProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
