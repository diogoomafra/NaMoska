namespace NaMoska
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool entrar(string usuario, string senha, string arquivo)
        {
            foreach (string linha in File.ReadAllLines(arquivo))
            {
                string[] partes = linha.Split(';');
                if (partes[0] == usuario && partes[1] == senha)
                {
                    return true; // Login correto
                }
            }
            return false; // Nenhuma correspondência encontrada
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string senha = txbSenha.Text;
            string usuario = txbUsuario.Text;
            string arquivo = "./arquivo.txt";


            bool autenticado = entrar(usuario, senha, arquivo);

            if (autenticado)
            {

                Form Timer= new Tempo();
                this.Hide();
                Timer.Show();

            }

            else MessageBox.Show("Não há um cadastro com estas credenciais!");

            if (string.IsNullOrWhiteSpace(senha) || string.IsNullOrWhiteSpace(usuario)) MessageBox.Show("Caracteres inválidos");


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form cadastro = new Cadastro();
            this.Hide();
            cadastro.Show();

        }
    }
}

