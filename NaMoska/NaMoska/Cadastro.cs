using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NaMoska
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void txbUsuarioReg_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //quando clicar em Já possuo uma conta, fazer:
            Form Login = new Form1(); //cria a variável nesse scopo sobre a tela de login
            Login.Show(); //abre a tela de login
            this.Hide(); //fecha a tela de cadastro

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //quando botão de entrar (no caso de registrar) for clicado, fazer:

            if (string.IsNullOrEmpty(txbConfSenha.Text) || string.IsNullOrEmpty(txbUsuarioReg.Text))
            //verifica se está em branco a caixa de texto de usuario ou de senha, se verdadeiro, fazer:
            {

                MessageBox.Show("Caracteres inválidos");//caixa de texto, avisar que os caracteres são invalidos

            }
            else if (txbConfSenha.Text == txbSenhaReg.Text)
            {

                string caminhoarquivo = ("arquivo.txt"); //salvar arquivos no diretório do código "./x.txt"
                StreamWriter writer; //cria a variável para abrir o arquivo de texto

                writer = File.AppendText(caminhoarquivo); //continua escrevendo no arquivo já existente (append)

                writer.WriteLine(txbUsuarioReg.Text + ";" + txbConfSenha.Text + ";");
                writer.Close();



                MessageBox.Show("Cadastro feito com sucesso");

                Form Login = new Form1();
                this.Hide();
                Login.Show();

            }
        }

    }
}
