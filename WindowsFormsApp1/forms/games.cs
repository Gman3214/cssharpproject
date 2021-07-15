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
        public List<WordWImage> gamewords = new List<WordWImage>();




        User player = new User();
        int points = 0;

        public frm_games(List<WordWImage> gamewords,User player)
        {
            this.player = player;
            this.gamewords = gamewords;
            InitializeComponent();
        }
        
        public int score
        {
            get { return points; }
            set { points = points+value; }
        }
        private void pix_game1_Click_1(object sender, EventArgs e)
        {
            gameone game1 = new gameone(this,gamewords);
            game1.Show();
        }

        private void pix_game2_Click(object sender, EventArgs e)
        {
            gametwo game2 = new gametwo(this);
            game2.Show();
        }

        private void pix_game3_Click(object sender, EventArgs e)
        {
            gametri game3 = new gametri(this);
            game3.Show();
        }

        private void pix_game4_Click(object sender, EventArgs e)
        {
            gamefour game4 = new gamefour(this);
            game4.Show();
        }
    }
}
