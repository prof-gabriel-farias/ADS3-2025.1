namespace Aula02
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Login = "gabriel";
            string Senha = "usc";

            if (tbLogin.Text == Login && tbSenha.Text == Senha)
            {
                //MessageBox.Show("Autenticado com Sucesso");
                lbMensagem.Text = "Autenticado com Sucesso - Bem vindo " + tbLogin.Text;
            }
            else
            {
                //MessageBox.Show("Usuário ou senha inválidos");
                lbMensagem.Text = "Usuário ou senha inválidos - Não existe usuário " + tbLogin.Text;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
