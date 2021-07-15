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
    public partial class gametwo : Form
    {

        private frm_games mainform = null;
        WordWImage[] gamewords = new WordWImage[3];
        User player = new User();
        int counter = 0; int index = -1; int sec = 5;// קואונטר עבור הסבב שלנו במשחק(לטיימר). אינדקס עבור המיקום שלנובמערך המילים. 

        public gametwo(Form callingForm, WordWImage[] gamewords, User player)
        {
            mainform = callingForm as frm_games;
            InitializeComponent();
            this.gamewords = gamewords;
            this.player = player;

        }

        private void gametwo_Load(object sender, EventArgs e)
        {
            lbl_exp.Text = "Explanation:\nby given a picture, you must write the word that describes the picture in the appropriate place.\n"
                + "Note! After a few seconds the image will disappear.Try to be as quick as possible";
            lbl_dir.Visible = false; txt_ans.Visible = false;
        }

        private void btn_str_Click(object sender, EventArgs e)
        {

            pic_slc.Visible = true; txt_ans.Enabled = false;
            btn_str.Visible = false; btn_str.Enabled = false; btn_chkans.Enabled = false; btn_chkans.Visible = true;
            lbl_dir.Visible = true; txt_ans.Visible = true;
            lbl_exp.Visible = false;
            tim_ans.Start(); tim_count.Start();
            lbl_showtime.Visible = true;
            lbl_timtitle.Visible = true;
            counter++;
            show_pic();
            //pic_slc.ImageLocation = @"DIMAGES\" + gamewords[index].wordimg;//תמונה ראשונה מופיעה למשתמש. 

        }
            
        private void show_pic()//מציגה תמונה
		{
            pic_score.Visible = false;lbl_score.Visible = false;
            index++;
            if (index == 3)
                return;
            pic_slc.ImageLocation = @"DIMAGES\" + gamewords[index].wordimg;
            txt_ans.Enabled = true; //btn_chkans.Enabled = false;
            sec = 5;
            if(txt_ans.Text==null)
                btn_chkans.Enabled = false;
        }
        int time = 5;
		private void tim_ans_Tick(object sender, EventArgs e)//אירועי טיימר  
		{


			lbl_exp.Visible = false; lbl_right.Visible = false;
			if (index <= 2)
			{
				show_pic();
				txt_ans.Clear();
				tim_count.Start();//טיימר ייחודי ל - 5 שניות  
				tim_ans.Start();
			}
			if (index == 3)
			{
				tim_ans.Stop();//זמן ייחודי
				tim_count.Stop();//זמן ייחודי
				lbl_timtitle.Visible = false; lbl_showtime.Visible = false;
				pic_slc.ImageLocation = @"ICONS\" + "gameover.png";
				lbl_exp.Visible = false; lbl_dir.Visible = false;
				lbl_title.Text = "Great Game! See you next time";
				btn_chkans.Visible = false; btn_chkans.Enabled = false; txt_ans.Visible = false;
				btn_rtn.Visible = true;
			}


		}
		
		private void tim_count_Tick(object sender, EventArgs e)//אירועי טיימר משני 
		{
            if (counter>= 3)
                tim_count.Stop();
            else if (counter<3)
                lbl_showtime.Text = sec.ToString();
            sec--;
        }

		private void btn_chkans_Click(object sender, EventArgs e)
		{
            txt_ans.Enabled = false; btn_chkans.Enabled = false;
           if(txt_ans.Text == gamewords[index].word)//כשהממשתמש צודק
			{
                player.chkmypast(gamewords[index]);
                pic_slc.ImageLocation = @"ICONS\" + "amazing.png";
                player.genralscore = player.genralscore + 10;
               
                lbl_exp.Visible = true;
                lbl_exp.Text = "Great job!";
            }
            else if(txt_ans.Text!= gamewords[index].word || txt_ans.Text == null)// כשהמשתמש טועה
			{
               pic_slc.ImageLocation = @"ICONS\" + "fail.png";
                player.genralscore = player.genralscore - 5;
                lbl_exp.Visible = true;
                lbl_exp.Text = " Sometimes we fail,\nMaybe next time we will succeed ";
                lbl_right.Visible = true; 
                lbl_right.Text = "The right word is:\n" + gamewords[index].word;
                player.updatemypast(gamewords[index]);// הוספת מילה שהיא טעות למערך המילים של טעויות משתמש
            }
            lbl_score.Visible = true; lbl_score.Text = "SCORE\n" + player.genralscore.ToString();
            pic_score.Visible = true;
        }

		private void txt_ans_TextChanged(object sender, EventArgs e)
		{
            btn_chkans.Enabled = true;
		}

        private void btn_rtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
