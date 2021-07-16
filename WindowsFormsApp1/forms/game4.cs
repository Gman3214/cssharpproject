using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace exam
{

    public partial class gamefour : Form
    {
        List<WordWImage> allgamewords = new List<WordWImage>();
        private frm_games mainform = null;
        SoundPlayer wordsound = new SoundPlayer();
        User player = new User();
        WordWImage[] randomwordsgame = new WordWImage[3];
        int roundnum = 0;
        int points = 0;
        WordWImage[] randomtopics = new WordWImage[2];
        WordWImage fake = null;
        static Random rnd = new Random();
        public gamefour(Form callingForm, WordWImage[] gamewords, User player, List<WordWImage> allgamewords)
        {
            this.allgamewords = allgamewords;
            mainform = callingForm as frm_games;
            this.randomwordsgame = gamewords;
            this.player = player;
            InitializeComponent();
            start();
        }
        public void start()
        {
            if (roundnum < 3)
            {
                wordsound.SoundLocation = @"VOICE/" + randomwordsgame[roundnum].wordwav;
                wordsound.Play();
                fake = allgamewords[getren()];
                int y = rnd.Next(0, 2);
                randomtopics[y] = randomwordsgame[roundnum];
                randomtopics[(y + 1) % 2] = fake;
                pic_left.ImageLocation = @"DIMAGES\" + randomtopics[0].wordimg;
                pic_right.ImageLocation = @"DIMAGES\" + randomtopics[1].wordimg;
                lbl_points.Text = "score:" + points;
            }
            else
            { 
                lbl_points.Text = "score:" + points; 
                btn_exit.Visible = true;
            }
                
        }
        private int getren()
        {
            int y = rnd.Next(allgamewords.Count);
            while (y == randomwordsgame[roundnum].wordid)
                y=getren();
            return y;
        }
        private void btn_sound_Click(object sender, EventArgs e)
        {
            wordsound.Play();
        }
        private void pic_left_Click(object sender, EventArgs e)
        {
            if (fake == randomtopics[1])
                win();
            else
                lose();

        }
        private void pic_right_Click(object sender, EventArgs e)
        {
            if (fake == randomtopics[0])
                win();
            else
                lose();
        }
        private void win()
        {
            player.chkmypast(randomwordsgame[roundnum]);
            roundnum++;
            lbl_enco.Visible = true;
            lbl_enco.Text = "you pressed the correct pic good job :3";
            points = points + 5;
            start();
        }
        private void lose()
        {
            player.updatemypast(randomwordsgame[roundnum]);
            roundnum++;
            lbl_enco.Visible = true;
            lbl_enco.Text = "you pressed the wrong pic, better luck next time :)";
            points = points - 5;
            start();
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            player.scoreupdate(points);
            this.Close();
        }
    }
}
