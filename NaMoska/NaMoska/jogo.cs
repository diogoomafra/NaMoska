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
    public partial class jogo : Form
    {
        private int Tempoutput;
        private int pontuacao = 0;
        private int segundos = 0;

        public jogo(int tempoch)
        {
            InitializeComponent();

            Tempoutput = tempoch;
            Seg.Interval = 1000;
            Seg.Start();

            timerMosca.Interval = 1000;
           
        }

        private void jogo_Load(object sender, EventArgs e)
        {
   
        }

        private void btnMosca_Click(object sender, EventArgs e)
        {   

            MoverBotao();

            pontuacao++;

            lblPonto.Text = "Pontos: " + pontuacao;


        }
        private void MoverBotao()
        {

            btnMosca.Visible = false;
            timerMosca.Stop();
            System.Threading.Thread.Sleep(50); //

            Random rand = new Random();
            int x = rand.Next(0, this.ClientSize.Width - btnMosca.Width);///
            int y = rand.Next(115, 581);

            btnMosca.Location = new Point(x, y);
            btnMosca.Visible = true;
            timerMosca.Start();
        }

        private void timerMosca_Tick(object sender, EventArgs e)
        {
            if(segundos < Tempoutput)
            {
                MoverBotao();
            }
        }

        private void lblPonto_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Seg_Tick(object sender, EventArgs e)
        {
            
            lblTempo.Text = "Tempo: " + segundos;
            if (segundos == Tempoutput)
            {

                Seg.Stop();
                btnMosca.Visible = false;

                Form final = new final(pontuacao, segundos);
                this.Hide();
                final.Show();
                

            }else if (segundos < Tempoutput)
            {
                
                segundos++;

            }
        }
    }
}
