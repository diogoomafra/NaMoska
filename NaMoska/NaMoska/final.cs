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
    
    public partial class final : Form
    {
        private int pontosrec, temporec;
        public final(int pontos, int tempo)
        {

            InitializeComponent();

            lblClics.Text = pontos.ToString();
            lblSeg.Text = tempo.ToString();
            pontosrec = pontos;
            temporec = tempo;

        }

        private void final_Load(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
             SaveFileDialog saveFileDialog = new SaveFileDialog();
             saveFileDialog.Filter = "Arquivos de Texto (.txt)|.txt|Todos os Arquivos (.)|."; 
             saveFileDialog.Title = "Salvar Arquivo";
             saveFileDialog.DefaultExt = "txt";
             saveFileDialog.FileName = "arquivo";

             if (saveFileDialog.ShowDialog() == DialogResult.OK)
             {
                 string caminhoArquivo = saveFileDialog.FileName;
                 StreamWriter writer; //cria a variável para abrir o arquivo de texto

                 writer = File.AppendText(caminhoArquivo); //continua escrevendo no arquivo já existente (append)

                 writer.WriteLine($"Cliques: {pontosrec} em {temporec} segundos;");
                 writer.Close();

             }

            
            // Voltar para o formulário de tempo
            Form timer = new Tempo();
            this.Hide();
            timer.Show();
        }

        /*private void SaveGameData()
        {
            // Obtém o caminho da área de trabalho
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(desktopPath, "historico.txt"); // Nome do arquivo

            string scoreEntry = $"Data: {   DateTime.Now:g} - Pontuação: {lblClics.Text}, Tempo: {lblSeg.Text}";

            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine(scoreEntry);
                }
                MessageBox.Show("Dados salvos com sucesso na área de trabalho!");
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show("Erro: Você não tem permissão para gravar neste local. " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar os dados: " + ex.Message);
            }
        }*/
    }
}