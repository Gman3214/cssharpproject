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
        private Form activeform = null;
        private void opengame(Form child)// פותחת את משחק שנשלח לה בקריאה לפונקציה
        {
            if (activeform != null)
                activeform.Close();
            activeform = child;
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            pnl_gamescreen.Controls.Add(child);
            pnl_gamescreen.Tag = child;
            child.BringToFront();
            child.Show();
        }
        private void pix_game1_Click(object sender, EventArgs e)
        {
            opengame(new frm_spelling());
        }

        private void pix_game2_Click(object sender, EventArgs e)
        {

        }

        private void pix_game3_Click(object sender, EventArgs e)
        {

        }

        private void pix_game4_Click(object sender, EventArgs e)
        {

        }
    }
}
