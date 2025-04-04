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
    public partial class Tempo : Form
    {

        private int tempoCh;

        public string TempoChose { get; set; }
        public Tempo()
        {
            InitializeComponent();

        }
        private void timer_Load(object sender, EventArgs e)
        {

        }

        private void btnplay15_Click(object sender, EventArgs e)
        {


            tempoCh = 15;
            Form game = new jogo(tempoCh);
            this.Hide();
            game.Show();

        }

        private void btnplay30_Click(object sender, EventArgs e)
        {

        }

        private void btnplay60_Click(object sender, EventArgs e)
        {

        }

        private void btnplay30_Click_1(object sender, EventArgs e)
        {

            tempoCh = 30;

            Form game = new jogo(tempoCh);
            this.Hide();
            game.Show();

        }

        private void btnplay60_Click_1(object sender, EventArgs e)
        {
     
        }

        private void btnplay60_Click_2(object sender, EventArgs e)
        {
            tempoCh = 60;

            Form game = new jogo(tempoCh);
            this.Hide();
            game.Show();
        }
    }
}