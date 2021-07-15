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

namespace exam
{
    public partial class gameone : Form
    {
        List<WordWImage> wordlist = new List<WordWImage>() ;
        private frm_games mainform = null;
        SoundPlayer wordsound = new SoundPlayer();
        static Random rnd = new Random();
        WordWImage currentword = null;
        int timeswrong = 0;
        int letterplacment = 0;
        public gameone(Form callingForm, List<WordWImage> gamewords)
        {
            mainform = callingForm as frm_games;
            wordlist = gamewords;
            int r = rnd.Next(wordlist.Count);
            currentword = wordlist[r];
            InitializeComponent();
            start();
        }

		private void Form3_Load(object sender, EventArgs e)
		{

		}

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if(letterplacment<currentword.word.Length-1 && timeswrong!=7)
            { 
                string tmp = null;
                if (txt_nextl.Text.Length != 1)
                    MessageBox.Show("pls enter just one letter into the txtbox");
                else
                {
                    if (txt_nextl.Text[0] == currentword.word[letterplacment])
                    {
                       for (int i = 0; i < currentword.word.Length-1; i++)
                       {
                           if(i==letterplacment)
                                tmp = tmp + txt_nextl.Text[0];
                           tmp = tmp + lbl_gusses.Text[i];
                       }
                        lbl_gusses.Text = tmp;
                        letterplacment++;
                        txt_nextl.Clear();
                        txt_nextl.Focus();
                    }
                    else
                    {
                        timeswrong++;
                        pic_hanged.ImageLocation = @"HANGEDMANGAME/lvl" + timeswrong + ".jpg";
                        txt_nextl.Clear();
                        txt_nextl.Focus();
                    }
                }
            }
            else if(letterplacment < currentword.word.Length-1 && timeswrong == 7)
            {
                lbl_gusses.Text = "you lose,better luck next time :)";
            }
            else if(letterplacment == currentword.word.Length-1 && timeswrong != 7)
            {
                lbl_gusses.Text = "good job you saved him!!!";
            }
        }
        public void start ()
        {
            foreach (char letter in currentword.word)
            {
                if (lbl_gusses.Text == "0")
                {
                    lbl_gusses.Visible = true;
                    lbl_gusses.Text = "-";
                }
                else
                    lbl_gusses.Text = lbl_gusses.Text + "-";
            }
            wordsound.SoundLocation = @"VOICE/" + currentword.wordwav;
            wordsound.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            wordsound.Play();
        }
    }
}
