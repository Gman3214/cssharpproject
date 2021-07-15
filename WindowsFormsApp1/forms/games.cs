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
        public List<WordWImage> gamewords
        {
            get { return gamewords; }
            set { this.gamewords = gamewords; }
        }
                

        User player = new User();
        int points = 0;

        public frm_games(List<WordWImage> gamewords,User player)
        {
            gamewords = new List<WordWImage>();
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
            gameone game1 = new gameone(this);
            game1.Show();
        }

        private void pix_game2_Click(object sender, EventArgs e)
        {
            gameone game2 = new gameone(this);
            game2.Show();
        }

        private void pix_game3_Click(object sender, EventArgs e)
        {
            gameone game3 = new gameone(this);
            game3.Show();
        }

        private void pix_game4_Click(object sender, EventArgs e)
        {
            gameone game4 = new gameone(this);
            game4.Show();
        }
    }
}
