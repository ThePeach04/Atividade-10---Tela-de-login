namespace Atividade_10___Tela_de_login
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "admin" && txtSenha.Text == "1234")
            {
                // Abrir Tela Principal
                TelaPrincipal telaPrincipal = new TelaPrincipal();
                telaPrincipal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.BackColor = Color.Red;
                txtSenha.BackColor = Color.Red;
            }
        }
    }
}
