﻿using System;
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
    public partial class gameone : Form
    {        
        private frm_games mainform = null;
        SoundPlayer wordsound = new SoundPlayer();
        int roundnum = 0;
        int timeswrong = 0;
        int letterplacment = 0;
        User player = new User();
        WordWImage[] randomwordsgame = new WordWImage[3];
        public gameone(Form callingForm,User player, WordWImage[] randomwordsgame)
        {
            this.randomwordsgame = randomwordsgame;
            this.player = player;
            mainform = callingForm as frm_games;
            InitializeComponent();
            lbl_score.Text = "score:" + player.genralscore;
            start();
        }

		private void Form3_Load(object sender, EventArgs e)
		{

		}

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (letterplacment < randomwordsgame[roundnum].word.Length  && timeswrong != 7)
            {
                if (txt_nextl.Text.Length != 1)
                {
                    MessageBox.Show("pls enter just one letter into the txtbox");
                    clearletter();
                }
                else
                {
                    checkletter();
                }
            }
            if (letterplacment == randomwordsgame[roundnum].word.Length  && timeswrong != 7)
            {
                goodend();
            }
            if (letterplacment < randomwordsgame[roundnum].word.Length  && timeswrong == 7)
            {
                badend();
            }
        }
        public void start ()
        {
            lbl_gusses.Text = "";
            btn_next.Visible = false;
            foreach (char letter in randomwordsgame[roundnum].word)
            {
                if (lbl_gusses.Text == "")
                {
                    lbl_gusses.Visible = true;
                    lbl_gusses.Text = "-";
                }
                else
                    lbl_gusses.Text = lbl_gusses.Text + "-";
            }
            wordsound.SoundLocation = @"VOICE/" + randomwordsgame[roundnum].wordwav;
            wordsound.Play();
        }
        private void goodend()
        {
            player.genralscore = player.genralscore + 10;
            if(roundnum==3)
            { btn_next.Text = "end game"; }
            lbl_gusses.Text = "good job you saved him!!!";
            ending();
        }
        private void badend()
        {
            player.wrongamewords.Add(randomwordsgame[roundnum].wordid);
            player.genralscore = player.genralscore - 10;
            if (roundnum == 3)
            { btn_next.Text = "end game"; }
            lbl_gusses.Text = "you lose,better luck next time :)";
            ending();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            wordsound.Play();
        }
        private void clearletter()
        {
            txt_nextl.Clear();
            txt_nextl.Focus();
        }
        private void checkletter()
        {
            string tmp = null;
            if (txt_nextl.Text[0] == randomwordsgame[roundnum].word[letterplacment])
            {
                for (int i = 0; i < randomwordsgame[roundnum].word.Length - 1; i++)
                {
                    if (i == letterplacment)
                        tmp = tmp + txt_nextl.Text[0];
                    tmp = tmp + lbl_gusses.Text[i];
                }
                lbl_gusses.Text = tmp;
                letterplacment++;
                lbl_encourage.Visible = true;
                lbl_encourage.Text = "yap nice work!";
                clearletter();
            }
            else
            {
                timeswrong++;
                pic_hanged.ImageLocation = @"HANGEDMANGAME/lvl" + timeswrong + ".jpg";
                clearletter();
                lbl_encourage.Visible = true;
                lbl_encourage.Text = "this letter is wrong";
            }
        }
        private void ending()
        {
            roundnum++;
            btn_next.Visible = true;
            lbl_encourage.Visible = false;
            timeswrong = 0;
            letterplacment = 0;
            lbl_score.Text = "score:" + player.genralscore;
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            pic_hanged.ImageLocation = @"HANGEDMANGAME/lvl" + timeswrong + ".jpg";
            if (roundnum == 3)
                this.Close();
            else
                start();
        }
    }
}
