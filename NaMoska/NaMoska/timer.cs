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

            int tempoCh = 15;
            Form game = new jogo(tempoCh);
            this.Hide();
            game.Show();

        }

        private void btnplay30_Click(object sender, EventArgs e)
        {
            int tempoCh3 = 30;
            Form game = new jogo(tempoCh3);
            this.Hide();
            game.Show();
        }

        private void btnplay60_Click(object sender, EventArgs e)
        {
            int tempoCh6 = 60;
            Form game = new jogo(tempoCh6);
            this.Hide();
            game.Show();
        }
    }
}
