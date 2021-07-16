using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam
{
    public partial class gametri : Form
    {
        private frm_games mainform = null;
        SoundPlayer sp = new SoundPlayer();
        int explaincount = 0;
        static Random rnd = new Random();
        WordWImage[] game_arr = new WordWImage[3];
        User player = new User();
        int round = 0;//ספירת סיבובים
        int miss;
        int points = 0;
        public gametri(Form callingForm ,WordWImage[] gamewords, User player)
        {
            mainform = callingForm as frm_games;
            InitializeComponent();
            this.game_arr = gamewords;
            this.player = player;
            lbl_exp.Text = "We need your help!\nSome words have lost some of their letters.\n" +
                "Maybe you can help us fix them?";
            btn_str.Text="yes i will";
        }

		private void btn_str_Click(object sender, EventArgs e)
		{
            explaincount++;

            lbl_exp.Text = "it's going to be wonderful! All you have to do is look at the picture,\n" +
                " hear the audio, and write the missing letter in the word that\n appears in front of you.";
            btn_str.Text = "OK";
            if(explaincount==2)
			{
                btn_str.Enabled = false;
                btn_str.Visible = false;
                startgame();
            }
        }
        private void startgame()
		{
                wordapperance();//הצגת המילה למשתמש
            wordpic_.Visible = true;pi_audio.Visible = true;ans_bx.Visible = true;ans_bx.Enabled = true;
            pi_audio.Enabled = true;
                wordpic_.ImageLocation= @"DIMAGES\" + game_arr[round].wordimg;//הצגת התמונה למשתמש
                chk_btn.Visible = true;chk_btn.Enabled = true;
            btn_end.Enabled = false;
            
		}

        private void wordapperance()// יצירת מילה עם _ במקום המתאים ובחירה רנדומלית של אות
		{
            string new_word = null;
            miss = rnd.Next(game_arr[round].letters.Length);// בחירת מיקום רנדומלי במערך האותיות של מילה בסיבוב
            for(int i=0;i< game_arr[round].letters.Length;i++)
			{
                if (i==miss)
                    new_word = new_word + "_";
                else new_word = new_word + game_arr[round].letters[i];
            }
            lbl_exp.Text = "What is the missing letter here?:\n" + new_word+"\nThe missing letter is:";
        }

		private void pi_audio_Click(object sender, EventArgs e)// אתחול נגן מדיה
		{
            sp.SoundLocation = @"VOICE/" + game_arr[round].wordwav;
            sp.Play();
        }
      
		private void chk_btn_Click(object sender, EventArgs e)
		{
            if (ans_bx.Text.Length != 1)
            {
                MessageBox.Show("only one letter is missing!\npls try again");
                ans_bx.Clear();
                ans_bx.Focus();
                startgame();
            }
            else
            {
                chk_btn.Enabled = false;
                Checkans();
            }
        }
        private void end()
		{

		}
        private void Checkans()
		{
            pi_audio.Enabled = false;
            //עבור תשובה נכונה
                 ans_bx.Enabled = false;
            feedbk_lbl.Visible = true;
                feedbk_pic.Visible = true;
                if (ans_bx.Text == game_arr[round].letters[miss].ToString())
                {
                    feedbk_lbl.Text = "Great work!\nI knew you can do this";
                    points = points + 10;
                    feedbk_pic.ImageLocation = @"ICONS\" + "start.png";
                    player.chkmypast(game_arr[round]);
                }
                else//תשובה לא נכונה
                {
                    points = points - 5;
                    feedbk_lbl.Text = "Dont Give UP\nmabye next time";
                    feedbk_pic.ImageLocation = @"ICONS\" + "spellbackg.png";
                    player.updatemypast(game_arr[round]);
                }
                round++;//עדכון סבב
                btn_end.Visible = true;
                btn_end.Enabled = true;
		}

		private void btn_end_Click(object sender, EventArgs e)
		{
            feedbk_pic.Visible = false;ans_bx.Clear();ans_bx.Focus();
            if (round < 3)
            {
                startgame();
                if (round == 2)
                    btn_end.Text = "End";
            }
            else
            {
                player.scoreupdate(points);
                this.Close();// יציאה מהתכנית 
            }
		}
	}
}
