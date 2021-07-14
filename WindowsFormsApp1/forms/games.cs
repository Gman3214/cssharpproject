using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam
{
    public partial class frm_games : Form
    {
        List<WordWImage> gamewords = new List<WordWImage>();

        public frm_games(List<WordWImage> gamewords)
        {
            this.gamewords = gamewords;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pix_game1_Click(object sender, EventArgs e)
        {

        }
    }
}
