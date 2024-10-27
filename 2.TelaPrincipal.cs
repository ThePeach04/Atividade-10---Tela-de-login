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
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void btnCadastroProduto_Click(object sender, EventArgs e)
        {
            TelaCadastroProduto telaCadastroProduto = new TelaCadastroProduto();
            telaCadastroProduto.Show();
        }

        private void btnListarProdutos_Click(object sender, EventArgs e)
        {
            TelaListaProdutos telaListaProdutos = new TelaListaProdutos();
            telaListaProdutos.Show();
        }
    }
}
