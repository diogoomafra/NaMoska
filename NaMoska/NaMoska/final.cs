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
        public final(int pontos, int tempo)
        {

            InitializeComponent();
               
            lblClics.Text = pontos.ToString();
            lblSeg.Text = tempo.ToString();
 

        }

        private void final_Load(object sender, EventArgs e)
        {

        }
    }
}
